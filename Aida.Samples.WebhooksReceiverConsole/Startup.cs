using System;
using System.Text.Json;
using Aida.Sdk.Mini.Api;
using Microsoft.AspNetCore.Builder;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Aida.Samples.WebhooksReceiverConsole.HostedServices;
using Aida.Samples.WebhooksReceiverConsole.Services.Messaging;

namespace Aida.Samples.WebhooksReceiverConsole
{
    public delegate IntegrationApi ApiClientFactory(string id);

    public class Startup
    {
        public Startup(IConfiguration configuration) { }

        /// <summary>
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_ => new MessageCollection());
            services.AddScoped(_ =>
            {
                var options = new JsonSerializerOptions();
                options.Converters.Add(new JsonStringEnumConverter());
                options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                return options;
            });
            services.AddTransient<ApiClientFactory>(_ => machineAddress =>
            {
                var url = $"http://{machineAddress}:5000";
                return new IntegrationApi(url);
            });
            // enable options pattern
            services.AddOptions();
            // register controllers in the service collection
            services.AddControllers()
                // json serializer options for asp netcore
                .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
            // this services handles messages that are stored stored in a blocking collection
            services.AddHostedService<MessagesBackgroundWorker>();
        }

        /// <summary>
        /// The configure method is invoked by the framework to build the application's pipeline (sequence of middlewares invoked for each request) 
        /// </summary>
        /// <param name="app"></param>
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            // enable routing
            app.UseRouting();
            // map controllers to routes
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}