using Aida.Samples.WebhooksReceiverConsole.HostedServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Aida.Samples.WebhooksReceiverConsole.Services.Messaging;
using Aida.Sdk.Mini.Api;

namespace Aida.Samples.WebhooksReceiverConsole
{
    public class Startup
    {
        protected IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

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
                return options;
            });

            // register the IntegrationApi as a transient service
            services.AddTransient(serviceProvider =>
            {
                var configuration = serviceProvider.GetRequiredService<IConfiguration>();
                return new IntegrationApi(configuration.GetValue<string>("IwsApiBaseUrl"));
            });

            // enable options pattern
            services.AddOptions();

            // register controllers in the service collection
            services.AddControllers()

                // json serializer options for asp netcore
                .AddJsonOptions(options => { options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); });

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
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}