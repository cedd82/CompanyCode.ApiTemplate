using CompanyCode.ApiTemplate.Common.Configuration;

using FACTS.GenericBooking.Repository.Postgres;

using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CompanyCode.ApiTemplate.Api.ExtensionMethods
{
    public static class AddPostgresConfigurationExtensions
    {
        public static void AddPostgresDbContextConfiguration(this IServiceCollection services,
            DatabaseConnections databaseConnections,
            //ILoggerFactory loggerFactory,
            IWebHostEnvironment hostingEnvironment)
        {
            services.AddDbContext<PostgresDbContext>(options =>
            {
                options.UseNpgsql(databaseConnections.PostgresDatabaseConnection);
                //options.UseLoggerFactory(loggerFactory);
                EventId[] events = new[] {new EventId(7777, "in memory linq execution in vlms")};
                if (hostingEnvironment.IsDevelopment())
                {
                    options.EnableSensitiveDataLogging();
                    options.ConfigureWarnings(x => x.Throw(events));
                }
                else
                {
                    options.ConfigureWarnings(x => x.Log(events));
                }
            });
            
        }
    }
}
