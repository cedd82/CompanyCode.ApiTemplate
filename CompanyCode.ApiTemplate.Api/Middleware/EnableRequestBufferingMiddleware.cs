﻿using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

namespace CompanyCode.ApiTemplate.Api.Middleware
{
    public class EnableRequestBufferingMiddleware
    {
        private readonly RequestDelegate _next;

        public EnableRequestBufferingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            context.Request.EnableBuffering();
            await _next(context);
        }
    }
}