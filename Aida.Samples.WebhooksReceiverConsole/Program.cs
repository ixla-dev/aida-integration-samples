using System;
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
            try
            {
                var host = CreateHostBuilder(args);
                await host.RunConsoleAsync();
            }
            catch
            {
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            var port = configuration.GetValue("Port", 7654);
            var abortOnError = configuration.GetValue("SendCancellationOnError", default(string));
            var encodingDuration = configuration.GetValue("MockEncodingDuration", TimeSpan.Zero);
            var encodingErrorRate = configuration.GetValue("EncodingErrorRate", 0);
            var logPayload = configuration.GetValue("LogMessagesPayload", false);

            Console.WriteLine($"Server listening on port: {port}");
            Console.WriteLine($"""
                               Configuration
                                 log_payload = {logPayload}
                                 listen_port = {port}
                                 encoding 
                                     error_rate = {encodingErrorRate}
                                     duration   = {encodingDuration}
                                 abort_on_error = {abortOnError}
                               """);


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
                    builder.ConfigureAppConfiguration(config => config.AddCommandLine(args))
                        // configure serilog for nicer console logging
                        .UseSerilog((c, loggerConfig) =>
                        {
                            loggerConfig
                                .ReadFrom.Configuration(c.Configuration)
                                .Enrich.FromLogContext();
                        })
                        .UseUrls($"http://0.0.0.0:{configuration.GetValue("Port", 7654)}")
                        // configure services and middleware pipeline
                        .UseStartup<Startup>();
                });
        }
    }
}