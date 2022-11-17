using System.Text.Json.Serialization;
using Aida.Samples.Integration.UI.Forms;
using Aida.Samples.Integration.UI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Aida.Samples.Integration.UI
{
    public class Startup
    {
        protected IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOptions();
            services.AddControllers()
                .AddJsonOptions(options => options
                .JsonSerializerOptions
                .Converters.Add(new JsonStringEnumConverter()));
            services.AddLogging(logging => logging.AddConsole().SetMinimumLevel(LogLevel.Trace));
            services.AddSingleton<WebhooksHandler>();
            services.AddSingleton<MainForm>();
            services.AddTransient<InsertDataForm>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}