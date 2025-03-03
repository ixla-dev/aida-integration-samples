using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;
using Aida.Tools.TemplateManager.Database;
using Aida.Tools.TemplateManager.Database.Models;

namespace Aida.Tools.TemplateManager.Services;

public class AssetManager(
    AssetManagerConfiguration config,
    TemplateManager templateManager)
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter() }
    };

    public async Task ImportTemplate(string name, string host)
    {
        var content  = await File.ReadAllTextAsync(Path.Combine(config.SourceAssetsDir, "job_templates", $"{name}.json"));
        var template = JsonSerializer.Deserialize<JobTemplate>(content)!;
        var helper = new DbHelper(
            new DbHelperConfiguration
            {
                Host = host,
                Username = "postgres",
                Password = "root"
            }
        );
        var layoutFiles = template.Layouts.Select(l => l.Layout.File);
        var patterns    = template.Layouts.SelectMany(l => l.AutoPosSettings.Select(p => p.TemplateMatchingConfiguration?.SearchPatternImage?.File)).Where(p => p is not null);
        
    }

    public async Task ExportEntitiesByLayoutId(int id)
    {
    }
    
    public async Task ExportJobTemplateAsync(string name)
    {
        var templateDir = Path.Combine(config.TargetAssetsDir, "job_templates", $"{name}");

        if (!Directory.Exists(templateDir))
            Directory.CreateDirectory(templateDir);

        var template = await templateManager.GetJobTemplateWithRelationsByName(name);

        await File.WriteAllTextAsync(
            Path.Combine(templateDir, $"{name}.json"),
            JsonSerializer.Serialize(template, SerializerOptions)
        );

        if (template.CardOrientationTemplateMatchingSettings is not null)
        {
            var patternImage = template.CardOrientationTemplateMatchingSettings?.SearchPatternImage;
            if (patternImage != null)
            {
                var sourcePattern = Path.Combine(config.SourceAssetsDir, patternImage.File.Location);
                var targetPattern = Path.Combine(templateDir, patternImage.File.Location);
                CopyFile(sourcePattern, targetPattern);
            }
        }

        if (template.File is not null)
        {
            var sourceFilePath = Path.Combine(config.SourceAssetsDir, template.File.Location);
            var targetFilePath = Path.Combine(templateDir, template.File.Location);
            CopyFile(sourceFilePath, targetFilePath);
        }

        foreach (var layout in template.Layouts)
        {
            var sourceLocation = Path.Combine(config.SourceAssetsDir, layout.Layout.File.Location);
            var targetLocation = Path.Combine(templateDir, layout.Layout.File.Location);
            CopyFile(sourceLocation, targetLocation);

            foreach (var autoPos in layout.AutoPosSettings)
            {
                var patternImage = autoPos.TemplateMatchingConfiguration?.SearchPatternImage;
                if (patternImage == null)
                    continue;
                var sourcePattern = Path.Combine(config.SourceAssetsDir, patternImage.File.Location);
                var targetPattern = Path.Combine(templateDir, patternImage.File.Location);
                CopyFile(sourcePattern, targetPattern);
            }
        }
    }

    private void CopyFile(string sourceLocation, string targetLocation)
    {
        var targetDir = Path.GetDirectoryName(targetLocation)!;
        Directory.CreateDirectory(targetDir);
        File.Copy(sourceLocation, targetLocation, true);
    }
}

public class AssetManagerConfiguration
{
    [Required] public required string SourceAssetsDir { get; set; }
    [Required] public required string TargetAssetsDir { get; set; }
}