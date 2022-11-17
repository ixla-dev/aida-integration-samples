using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aida.Samples.Integration.UI.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Aida.Samples.Integration.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var host = CreateHostBuilder().Build();
            using var sScope = host.Services.CreateScope();
            _ = Task.Run(async () => await host.RunAsync());
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(sScope.ServiceProvider.GetRequiredService<MainForm>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host
                .CreateDefaultBuilder()
                .UseConsoleLifetime()
                .ConfigureWebHostDefaults(conf => conf.UseStartup<Startup>());
        }
    }
}