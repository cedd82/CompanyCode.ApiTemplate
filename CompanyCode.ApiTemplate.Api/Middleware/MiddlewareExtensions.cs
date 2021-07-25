using Microsoft.AspNetCore.Builder;

namespace CompanyCode.ApiTemplate.Api.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseEnableRequestBuffering(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<EnableRequestBufferingMiddleware>();
        }

        public static IApplicationBuilder UseExceptionHandlerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}