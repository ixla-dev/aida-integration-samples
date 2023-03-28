using System.Text.Json;
using System.Text.Json.Serialization;
using Aida.Samples.Integration.UI.Forms;
using Aida.Samples.Integration.UI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aida.Samples.Integration.UI
{
    public class Startup
    {
        protected IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped(_ =>
            {
                var options = new JsonSerializerOptions();
                options.Converters.Add(new JsonStringEnumConverter());
                return options;
            });
            services.AddOptions();
            services.AddControllers();
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