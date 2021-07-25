using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

using CompanyCode.ApiTemplate.Common.Constants;

using Microsoft.Extensions.DependencyInjection;

namespace CompanyCode.ApiTemplate.Api.ExtensionMethods
{
    public static class AddAuthorisationConfigurationExtension
    {
        public static void AddCustomAuthorisationPolicies(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Admin", policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        bool? isAuthenticated = context.User?.Identity?.IsAuthenticated;
                        if (isAuthenticated == false)
                            return false;
                        IEnumerable<Claim> claims = context.User.Claims;
                        string roles = claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;
                        if (string.IsNullOrEmpty(roles))
                            return false;
                        List<string> items = roles.Split(',').ToList();

                        bool authorised = items.Contains(CommonConstants.AuthRoles.CevaSiteAdmin);
                        return authorised;

                    });
                });
                options.AddPolicy("StorageMobileOperator", policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        bool? isAuthenticated = context.User?.Identity?.IsAuthenticated;
                        if (isAuthenticated == false)
                            return false;
                        IEnumerable<Claim> claims = context.User.Claims;
                        string roles = claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;
                        if (string.IsNullOrEmpty(roles))
                            return false;
                        List<string> items = roles.Split(',').ToList();

                        bool authorised = items.Contains(CommonConstants.AuthRoles.YardOperatorMobile) || items.Contains(CommonConstants.AuthRoles.WharfOperatorMobile) || items.Contains(CommonConstants.AuthRoles.Agent);
                        return authorised;

                    });
                });
                options.AddPolicy("StorageMobileAgentOperator", policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        bool? isAuthenticated = context.User?.Identity?.IsAuthenticated;
                        if (isAuthenticated == false)
                            return false;
                        IEnumerable<Claim> claims = context.User.Claims;
                        string roles = claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;
                        if (string.IsNullOrEmpty(roles))
                            return false;
                        List<string> items = roles.Split(',').ToList();

                        bool authorised = items.Contains(CommonConstants.AuthRoles.Agent);
                        return authorised;

                    });
                });
                options.AddPolicy("Operator", policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        bool? isAuthenticated = context.User?.Identity?.IsAuthenticated;
                        if (isAuthenticated == false)
                            return false;
                        IEnumerable<Claim> claims = context.User.Claims;
                        string roles = claims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value;
                        if (string.IsNullOrEmpty(roles))
                            return false;
                        List<string> items = roles.Split(',').ToList();

                        bool authorised = items.Contains(CommonConstants.AuthRoles.CevaSiteOperator) || items.Contains(CommonConstants.AuthRoles.Agent) || items.Contains(CommonConstants.AuthRoles.CevaSiteAdmin);
                        return authorised;

                    });
                });
            });
        }
    }
}
