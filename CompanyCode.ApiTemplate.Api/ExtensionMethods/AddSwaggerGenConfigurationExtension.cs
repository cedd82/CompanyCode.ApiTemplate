using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using CompanyCode.ApiTemplate.Common.Configuration;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

using Swashbuckle.AspNetCore.SwaggerGen;

namespace CompanyCode.ApiTemplate.Api.ExtensionMethods
{
    public static class AddSwaggerGenConfigurationExtension
    {
        public static void AddSwaggerGenConfiguration(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddSwaggerGen(c =>
            {
                OpenApiSecurityScheme openApiSecurityScheme = new()
                {
                    Description = "JWT Authorization header using the Bearer scheme.",
                    In          = ParameterLocation.Header,
                    Type        = SecuritySchemeType.Http,
                    Scheme      = "bearer"
                };
                c.AddSecurityDefinition("Bearer", openApiSecurityScheme);
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Id   = "Bearer",
                                Type = ReferenceType.SecurityScheme
                            }
                        },
                        new List<string>()
                    }
                });

                c.SwaggerDoc("v1", new OpenApiInfo {Title = appSettings.ApplicationName, Version = $"v1-{appSettings.ApplicationVersion}"});
                string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        private class PascalCasePropertyFilter : ISchemaFilter
        {
            public void Apply(OpenApiSchema model, SchemaFilterContext context)
            {
                model.Properties = model.Properties.ToDictionary(d => d.Key.Substring(0, 1).ToUpper() + d.Key[1..], d => d.Value);
            }

            //    public static void AddSwaggerGenConfiguration(this IServiceCollection services, IConfiguration configuration, CommonAppSettings commonAppSettings)
            //{
            //    // register fluent validation assemblies
            //    List<ServiceDescriptor> serviceDescriptors = services.Where(descriptor => descriptor.ServiceType.GetInterfaces().Contains(typeof(IValidator))).ToList();
            //    serviceDescriptors.ForEach(descriptor => services.Add(ServiceDescriptor.Transient(typeof(IValidator), descriptor.ImplementationType)));
            //    // used for documentation markup
            //    //services.AddSwaggerExamples();
            //    services.AddSwaggerGen(c =>
            //    {
            //        // used for documentation markup
            //        //c.ExampleFilters();
            //        c.SchemaFilter<PascalCasePropertyFilter>();

            //        c.CustomSchemaIds(type => type.ToString());
            //        c.OperationFilter<TagByApiExplorerSettingsOperationFilter>();
            //        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            //        {
            //            Description = "JWT Authorization header using the Bearer scheme.",
            //            In          = ParameterLocation.Header,
            //            Type        = SecuritySchemeType.Http,
            //            Scheme      = "bearer"
            //        });
            //        c.AddSecurityRequirement(new OpenApiSecurityRequirement
            //        {
            //            {
            //                new OpenApiSecurityScheme
            //                {
            //                    Reference = new OpenApiReference
            //                    {
            //                        Id   = "Bearer",
            //                        Type = ReferenceType.SecurityScheme
            //                    }
            //                },
            //                new List<string>()
            //            }
            //        });
            //        c.EnableAnnotations();
            //        c.AddFluentValidationRules();
            //        c.SwaggerDoc("v1", new OpenApiInfo {Title = commonAppSettings.ApplicationName, Version = commonAppSettings.ApiVersion});
            //        string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            //        string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            //        c.IncludeXmlComments(xmlPath);
            //    });
            //    services.AddSwaggerGenNewtonsoftSupport();
            //}
        }
    }
}