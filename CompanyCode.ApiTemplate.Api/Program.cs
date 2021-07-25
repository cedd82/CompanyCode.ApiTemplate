using System.IO;

using CompanyCode.ApiTemplate.Common.Configuration;

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using NLog;
using NLog.Web;

using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace CompanyCode.ApiTemplate.Api
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Logger logger = NLogBuilder.ConfigureNLog("nlog.config").GetCurrentClassLogger();
            logger.Info("init main");
            logger.Info("building webhost");

            IWebHostBuilder hostBuilder = WebHost
                .CreateDefaultBuilder(args)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    IWebHostEnvironment env = hostingContext.HostingEnvironment;
                    config.AddEnvironmentVariables();
                    config
                        .AddJsonFile("appsettings.json", true, true)
                        .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true, true);
                    IConfigurationRoot configurationRoot = config.Build();
                    DatabaseConnections databaseConnections = configurationRoot.GetSection("AppSecrets").Get<DatabaseConnections>();
                    LogManager.Configuration.Variables["connectionString"] = databaseConnections.PostgresDatabaseConnection;
                })
                .ConfigureLogging(logging =>
                {
                    logging.ClearProviders();
                    logging.SetMinimumLevel(LogLevel.Information);
                })
                .UseNLog()
                .UseIISIntegration();

            IWebHost webHost = hostBuilder.Build();
            webHost.Run();
        }
    }

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        CreateHostBuilder(args).Build().Run();
    //    }

    //    public static IHostBuilder CreateHostBuilder(string[] args) =>
    //        Host.CreateDefaultBuilder(args)
    //            .ConfigureWebHostDefaults(webBuilder =>
    //            {
    //                webBuilder.UseStartup<Startup>();
    //            });
    //}
}