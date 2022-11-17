using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using System.Threading.Tasks;

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
                        // configure services and middleware pipeline
                        builder.UseStartup<Startup>();
                        // configure serilog for nicer console logging
                        builder.UseSerilog((_, loggerConfig) =>
                        {
                            loggerConfig
                                .ReadFrom.Configuration(_.Configuration)
                                .Enrich.FromLogContext();
                        });
                    }
                );
        }
    }
}