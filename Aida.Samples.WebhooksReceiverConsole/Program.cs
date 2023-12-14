using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Aida.Samples.WebhooksReceiverConsole
{
    public class Program
    {
        /// <summary>
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args);
            await host.RunConsoleAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            // This is just boilerplate to setup ASP .NETCore
            // the startup class is used by the dependency injection system
            // to configure the object dependency graph of the application
            return Host
                .CreateDefaultBuilder(args)
                // allow to kill the app with CTRL+C
                .UseConsoleLifetime()
                // configure the web stack
                .ConfigureWebHostDefaults(builder =>
                {
                    builder.ConfigureAppConfiguration(config => config.AddCommandLine(args));
                    builder.UseUrls($"http://0.0.0.0:{configuration.GetValue("Port", 7654)}");
                    // configure services and middleware pipeline
                    builder.UseStartup<Startup>();
                    // configure serilog for nicer console logging
                    builder.UseSerilog((c, loggerConfig) =>
                    {
                        loggerConfig
                            .ReadFrom.Configuration(c.Configuration)
                            .Enrich.FromLogContext();
                    });
                });
        }
    }
}