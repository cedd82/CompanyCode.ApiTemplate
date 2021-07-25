using System;
using System.Text;
using System.Threading.Tasks;

using CompanyCode.ApiTemplate.Common.Configuration;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace CompanyCode.ApiTemplate.Api.ExtensionMethods
{
    public static class AddJwtConfigurationExtension
    {
        public static void AddJwtConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            JwtSettings jwtSettings = configuration.GetSection("JwtSettings").Get<JwtSettings>();
            AppSettings appSettings = configuration.GetSection("AppSettings").Get<AppSettings>();
            AppSecrets appSecrets = configuration.GetSection("AppSecrets").Get<AppSecrets>();
            services.AddSwaggerGen(c => { c.SwaggerDoc(appSettings.ApplicationName, new OpenApiInfo {Title = appSettings.ApplicationName, Version = appSettings.ApplicationVersion}); });
            services.AddSingleton(jwtSettings);

            byte[] signingKeyBytes = Encoding.ASCII.GetBytes(appSecrets.JwtSymmetricKey);
            SymmetricSecurityKey signingKey = new(signingKeyBytes);

            services.AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme    = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultScheme             = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.Events = new JwtBearerEvents
                    {
                        OnTokenValidated = context =>
                        {
                            string userCode = context.Principal?.Identity?.Name?.ToUpper();
                            if (string.IsNullOrEmpty(userCode))
                                context.Fail("Unauthorized");

                            return Task.CompletedTask;
                        }
                    };
                    x.RequireHttpsMetadata = false;
                    x.SaveToken            = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        //todo set to true once urls are finalised
                        ValidateIssuer           = false,
                        ValidateAudience         = false,
                        ValidateLifetime         = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer              = jwtSettings.Issuer,
                        ValidAudience            = jwtSettings.Audience,
                        IssuerSigningKey         = signingKey,
                        ClockSkew                = TimeSpan.FromMinutes(2)
                    };
                });
        }
    }
}