using System.ComponentModel.DataAnnotations;
using Aida.Tools.TemplateManager.Database;
using Aida.Tools.TemplateManager.Services;
using Microsoft.Extensions.Configuration;
using ValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace Aida.Tools.TemplateManager;

internal class Program
{
    public static async Task Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddCommandLine(
                args, new Dictionary<string, string>
                {
                    ["--source-assets-dir"] = "SourceAssetsDir",
                    ["--target-assets-dir"] = "TargetAssetsDir",
                    ["-s"] = "SourceAssetsDir",
                    ["-o"] = "TargetAssetsDir",
                }
            )
            .Build();

        var dbConfig = new DbHelperConfiguration
        {
            Username = configuration.GetValue<string>("Username"),
            Password = configuration.GetValue<string>("Password"),
            Host = configuration.GetValue<string>("Host"),
        };

        var assetManagerConfig = new AssetManagerConfiguration
        {
            SourceAssetsDir = configuration.GetValue<string>("SourceAssetsDir"),
            TargetAssetsDir = configuration.GetValue<string>("TargetAssetsDir"),
        };

        ICollection<ValidationResult> dbConfigValidationResult = new List<ValidationResult>();
        if (!Validator.TryValidateObject(dbConfig, new ValidationContext(dbConfig), dbConfigValidationResult, true))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (var r in dbConfigValidationResult)
                Console.WriteLine($"[ERR] {r.ErrorMessage}");
            Console.ResetColor();
            return;
        }

        ICollection<ValidationResult> assetManagerConfigValidationResult = new List<ValidationResult>();
        if (!Validator.TryValidateObject(dbConfig, new ValidationContext(dbConfig), assetManagerConfigValidationResult, true))
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            foreach (var r in assetManagerConfigValidationResult)
                Console.WriteLine($"[ERR] {r.ErrorMessage}");
            Console.ResetColor();
            return;
        }

        var dbHelper = new DbHelper(dbConfig);
        await dbHelper.ConnectAsync();

        var templateManager = new Services.TemplateManager(dbHelper);
        var assetManager    = new AssetManager(assetManagerConfig, templateManager);
        foreach (var template in await templateManager.ListJobTemplates())
            await assetManager.ExportJobTemplateAsync(template.Name);
    }
}