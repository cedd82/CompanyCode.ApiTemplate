using System;
using System.Data.Odbc;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using CompanyCode.ApiTemplate.Common.Configuration;
using CompanyCode.ApiTemplate.Common.Email;
using CompanyCode.ApiTemplate.Common.ErrorMessages;

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

using Newtonsoft.Json;

using NHibernate;

using NLog;

namespace CompanyCode.ApiTemplate.Api.Middleware
{
    public class ExceptionHandlerMiddleware
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private readonly RequestDelegate _next;
        private const int OneHundred28Kb = 128000;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context,
                                 IEmailService emailService,
                                 IWebHostEnvironment hostingEnvironment,
                                 IHostApplicationLifetime appLifetime,
                                 CommonAppSettings commonAppSettings,
                                 IHttpContextAccessor httpContextAccessor)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (TransactionException exception)
            {
                Exception innerException = exception.InnerException;
                Type innerType = innerException?.GetType();
                if (innerType == typeof(OdbcException) && exception.Message.Contains("Begin failed with SQL exception"))
                {
                    string exceptionString = $"{exception}";
                    if (exceptionString.Contains("NHibernate.Connection.DriverConnectionProvider.GetConnection()"))
                    {
                        if (commonAppSettings.StopAppOnOdbcConnectionFailure)
                        {
                            appLifetime.StopApplication();
                            CancellationToken cancellationToken = appLifetime.ApplicationStopped;
                            Logger.Error($"Stopping application IsCancellationRequested:{cancellationToken.IsCancellationRequested} CanBeCanceled:{cancellationToken.CanBeCanceled}");
                        }

                        await HandleExceptionAsync(context, exception, emailService, appLifetime, httpContextAccessor, hostingEnvironment, commonAppSettings);
                    }
                }
            }
            catch (Exception exception)
            {
                await HandleExceptionAsync(context, exception, emailService, appLifetime, httpContextAccessor, hostingEnvironment, commonAppSettings);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context,
                                                Exception exception,
                                                IEmailService emailService,
                                                IHostApplicationLifetime appLifetime,
                                                IHttpContextAccessor httpContextAccessor,
                                                IWebHostEnvironment hostingEnvironment,
                                                CommonAppSettings commonAppSettings)
        {
            Logger.Error(exception, $"Unhandled Exception message: {exception.Message}");
            Type exceptionType = exception.GetType();
            Exception innerException = exception.InnerException;
            Type innerExceptionType = innerException?.GetType();
            HttpRequest httpRequest = httpContextAccessor.HttpContext.Request;
            bool? isAuthenticated = context.User?.Identity?.IsAuthenticated;
            string userCode = null;
            if (isAuthenticated == true)
            {
                userCode = context.User?.Identity?.Name;
            }

            string requestBody = string.Empty;
            bool catchBody = true;
            bool sendErrorEmail = true;
            if (httpRequest.Path == "/ManifestProcesses/saveVehiclePhotos")
            {
                catchBody = false;
            }

            if (exceptionType == typeof(Microsoft.AspNetCore.Connections.ConnectionResetException))
            {
                catchBody = false;
                sendErrorEmail = false;
            }
            
            if (catchBody && commonAppSettings.CapturePostRequestBodyOnError && httpRequest.Method == "POST")
            {
                requestBody = await GetRequestBodyAsync(context);
            }

            if (sendErrorEmail)
            {
                SendErrorEmail(exception, emailService, appLifetime, httpRequest, isAuthenticated, requestBody, userCode, exceptionType, innerExceptionType);
            }

            HttpResponse response = context.Response;
            response.ContentType = "application/json";
            response.StatusCode  = (int) HttpStatusCode.BadRequest;
            await response.WriteAsync(JsonConvert.SerializeObject(new
            {
                Status = new
                {
                    Message = CommonErrorMessages.ApiException.ToString(),
                    CommonErrorMessages.ApiException.Level,
                    Timestamp = DateTime.Now.ToString("s")
                }
            })).ConfigureAwait(false);
        }
        
        private async Task<string> GetRequestBodyAsync(HttpContext context)
        {
            // protect api against failure on large byte size payloads, known issue where model binding fails where req > 64kb
            // https://stackoverflow.com/questions/49672813/request-with-size-over-64kb-fails-to-complete-asp-net-core-web-api
            if (context.Request.Body.Length > OneHundred28Kb)
            {
                return $"body size {context.Request.Body.Length} is larger than 128KB; too large to seralise.";
            }

            await using MemoryStream stream = new();
            context.Request.Body.Seek(0, SeekOrigin.Begin);
            await context.Request.Body.CopyToAsync(stream);
            string requestBody = Encoding.UTF8.GetString(stream.ToArray());
            context.Request.Body.Seek(0, SeekOrigin.Begin);
            return requestBody;
        }

        private static void SendErrorEmail(Exception exception,
                                           IEmailService emailService,
                                           IHostApplicationLifetime appLifetime,
                                           HttpRequest httpRequest,
                                           bool? isAuthenticated,
                                           string requestBody,
                                           string userCode,
                                           Type exceptionType,
                                           Type innerExceptionType)
        {
            string body = $@"
                            Request: {httpRequest.Method} {httpRequest.Scheme}://{httpRequest.Host}{httpRequest.Path}{httpRequest.QueryString}
                            IsAuthenticated: {isAuthenticated}
                            RequestBodyIfPost: 

                            {requestBody}

                            UserCode: {userCode}
                            ExceptionType: {exceptionType.Name}
                            InnerExceptionTypeIfAny: {innerExceptionType?.Name}
                            StopApplication Called: {appLifetime.ApplicationStopped.IsCancellationRequested}
                            Exception: {exception}";
            string subject = $"Unhandled Exception caught in global exception handler {exception.Message}";

            emailService.SendErrorEmail(subject, body);
        }
    }
}