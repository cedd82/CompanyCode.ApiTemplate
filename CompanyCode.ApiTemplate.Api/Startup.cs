using System.IO;
using System.Reflection;

using CompanyCode.ApiTemplate.Api.ExtensionMethods;
using CompanyCode.ApiTemplate.Api.Mappers;
using CompanyCode.ApiTemplate.Api.Middleware;
using CompanyCode.ApiTemplate.Common.Configuration;
using CompanyCode.ApiTemplate.Common.Email;
using CompanyCode.ApiTemplate.Domain.Mappers;

using FluentValidation.AspNetCore;

using MicroElements.Swashbuckle.FluentValidation;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CompanyCode.ApiTemplate.Api
{
    public class Startup
    {
        private static readonly string CorsPolicy = "Cors";
        private readonly IWebHostEnvironment _hostingEnvironment;

        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            Configuration       = configuration;
            _hostingEnvironment = env;
        }

        private IConfiguration Configuration { get; }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            ForwardedHeadersOptions options = new()
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            };

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CompanyCode.ApiTemplate.Api v1"));
            }

            app.UseXfo(x => x.Deny());
            app.UseXContentTypeOptions();
            app.UseAuthentication();
            app.UseForwardedHeaders(options);
            app.UseMiddleware<EnableRequestBufferingMiddleware>();
            app.UseMiddleware<ExceptionHandlerMiddleware>();
            app.UseMiddleware<SecureSwaggerBasicAuthMiddleware>();
            app.UseHttpsRedirection();
            app.UseCors(CorsPolicy);
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecks("/health");
            });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            AppSettings appSettings = Configuration.GetSection("AppSettings").Get<AppSettings>();
            appSettings.EnvironmentName = _hostingEnvironment.EnvironmentName;
            string executingAssemblyFile = Assembly.GetEntryAssembly()?.Location;
            string executingAssemblyDirectory = Path.GetDirectoryName(executingAssemblyFile);
            appSettings.ContentRootPath = executingAssemblyDirectory;
            services.AddSingleton(appSettings);
            services.AddSingleton(Configuration.GetSection("EmailSettings").Get<EmailSettings>());
            AppSecrets appSecrets = Configuration.GetSection("AppSecrets").Get<AppSecrets>();
            services.AddSingleton(appSecrets);
            DatabaseConnections databaseConnections = new()
            {
                IngresDatabaseConnection   = appSecrets.IngresDatabaseConnection,
                PostgresDatabaseConnection = appSecrets.PostgresDatabaseConnection
            };
            services.AddSingleton(databaseConnections);
            services.AddJwtConfiguration(Configuration);
            services.AddCustomAuthorisationPolicies();
            services.AddMemoryCache();
            services.AddDetection();
            services.AddHttpContextAccessor();
            services.AddTransient(s => s.GetService<IHttpContextAccessor>().HttpContext.User);
            services.AddHealthChecks();

            services.AddControllers(options =>
                {
                    //options.Filters.Add(new FluentValidateAttribute());
                    options.OutputFormatters.RemoveType<TextOutputFormatter>();
                    options.OutputFormatters.RemoveType<HttpNoContentOutputFormatter>();
                })
                .AddJsonOptions(options => { options.JsonSerializerOptions.PropertyNamingPolicy = null; })
                .AddFluentValidation(fv =>
                {
                    fv.RegisterValidatorsFromAssemblyContaining<Startup>();
                    fv.ValidatorFactoryType                     = typeof(HttpContextServiceProviderValidatorFactory);
                    fv.ImplicitlyValidateRootCollectionElements = true;
                });

            services.AddSwaggerGenConfiguration(appSettings);

            // databases
            services.AddPostgresDbContextConfiguration(databaseConnections, _hostingEnvironment);
            services.AddIngresNHibernateConfiguration(databaseConnections);

            services.AddCors(options => options.AddPolicy(CorsPolicy, builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));
            services.AddAutoMapper(typeof(ApiAutomapperProfile).Assembly, typeof(DomainAutomapperProfile).Assembly);

            // services
            services.AddSingleton<IEmailService, EmailService>();
        }
    }
}