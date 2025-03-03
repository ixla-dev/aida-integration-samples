using Aida.Sdk.Model;
using Aida.Tools.TemplateManager.Database;
using ApplicationFile = Aida.Tools.TemplateManager.Database.Models.ApplicationFile;
using ApplicationImage = Aida.Tools.TemplateManager.Database.Models.ApplicationImage;
using JobTemplate = Aida.Tools.TemplateManager.Database.Models.JobTemplate;
using JobTemplateLayout = Aida.Tools.TemplateManager.Database.Models.JobTemplateLayout;
using JobTemplateLayoutAutoPosSettings = Aida.Tools.TemplateManager.Database.Models.JobTemplateLayoutAutoPosSettings;
using Layout = Aida.Tools.TemplateManager.Database.Models.Layout;
using TemplateMatchingConfiguration = Aida.Tools.TemplateManager.Database.Models.TemplateMatchingConfiguration;

namespace Aida.Tools.TemplateManager.Services;

public class TemplateManager(DbHelper db)
{
    public async Task<List<JobTemplate>> ListJobTemplates(string orderBy = "Id", SortDirection sortDirection = SortDirection.Ascending)
    {
        var dir = sortDirection is SortDirection.Ascending ? "asc" : "desc";
        var result = await db.QueryAsync<JobTemplate>(
            $"""
             select * from "JobTemplates"
             order by @orderBy {dir}
             offset @offset limit @limit
             """,
            new Dictionary<string, object>
            {
                ["@offset"] = 0,
                ["@limit"] = 1000,
                ["@orderBy"] = orderBy,
            },
            reader => reader.GetJobTemplate()
        );
        return result;
    }

    public async Task<int> RenameJobTemplate(string name, string newName)
    {
        return await db.ExecuteNonQueryAsync(
            """
            update "JobTemplates" set "Name" = @newName where "Name" = @name
            """,
            new Dictionary<string, object>
            {
                ["@name"] = name,
                ["@newName"] = newName,
            }
        );
    }

    public async Task<JobTemplate> GetJobTemplateWithRelationsByName(string name)
    {
        var template = await GetJobTemplateByName(name);
        if (template is null)
            throw new Exception($"Job template with name '{name}' does not exists.");

        var templateLayouts = await GetJobTemplateLayouts(template.Id);
        var layouts         = await GetLayoutsById(templateLayouts.Select(tpl => tpl.LayoutId).ToArray());
        var layoutFiles     = await GetFilesById(layouts.Select(l => l.FileId).ToArray());

        var autoPosSettings                = await GetAutoPosSettingsByJobTemplateLayoutId(templateLayouts.Select(tpl => tpl.Id).ToArray());
        var templateMatchingConfigurations = await GetTemplateMatchingConfigurationsById(autoPosSettings.Select(c => c.TemplateMatchingConfigurationId).ToArray());
        var cardOrientationTplMatching     = await GetTemplateMatchingConfigurationsById(template.CardOrientationTemplateMatchingSettingsId ?? -1);

        var searchPatternImages = await GetImagesById(templateMatchingConfigurations.Select(c => c.SearchPatternImageId).ToArray());
        var searchPatternFiles  = await GetFilesById(searchPatternImages.Select(i => i.FileId).ToArray());

        template.CardOrientationTemplateMatchingSettings = cardOrientationTplMatching.FirstOrDefault();

        if (template.FileId is not null)
            template.File = (await GetFilesById(template.FileId.Value)).First();

        foreach (var layout in layouts)
            layout.File = layoutFiles.First(f => f.Id == layout.FileId);

        foreach (var image in searchPatternImages)
            image.File = searchPatternFiles.First(f => f.Id == image.FileId);

        foreach (var tplMatch in templateMatchingConfigurations)
            tplMatch.SearchPatternImage = searchPatternImages.FirstOrDefault(i => i.Id == tplMatch.SearchPatternImageId);

        foreach (var autoPos in autoPosSettings)
            autoPos.TemplateMatchingConfiguration = templateMatchingConfigurations.FirstOrDefault(tpl => tpl.Id == autoPos.TemplateMatchingConfigurationId);

        foreach (var templateLayout in templateLayouts)
        {
            templateLayout.Layout = layouts.First(l => l.Id == templateLayout.LayoutId);
            templateLayout.AutoPosSettings.AddRange(autoPosSettings.Where(c => c.JobTemplateLayoutId == templateLayout.Id));
        }

        template.Layouts.AddRange(templateLayouts);

        return template;
    }

    public async Task<List<Dictionary<string, object>>> ExportEntitiesByLayoutId(int id)
    {
        var result = await db.QueryAsync(
            """
            select * from "Entities" 
            where "LayoutId" = @layoutId
            """,
            new Dictionary<string, object>() { ["@layoutId"] = id },
            result => result.ToDictionary()
        );
        return result;
    }

    public async Task<JobTemplate?> GetJobTemplateByName(string name)
    {
        var result = await db.QueryAsync(
            """
            select * from "JobTemplates" where "Name" = @name
            """, new Dictionary<string, object>
            {
                ["@name"] = name
            }, reader => reader.GetJobTemplate()
        );
        return result.FirstOrDefault();
    }

    public async Task<int> RenameJobTemplate(int id, string name)
    {
        return await db.ExecuteNonQueryAsync(
            """
            update "JobTemplates" set "Name" = @name where "Id" = @id
            """,
            new Dictionary<string, object>
            {
                ["@name"] = name,
                ["@id"] = id,
            }
        );
    }
    public (string argsList, Dictionary<string, object>) BuildIdList(int[] ids)
    {
        var names    = ids.Select((_, index) => $"@id_{index}");
        var nameList = string.Join(",", names);
        var result   = new Dictionary<string, object>();
        var index    = 0;
        foreach (var name in names)
        {
            result.Add(name, ids[index]);
            index++;
        }

        return (nameList, result);
    }

    public async Task<List<ApplicationFile>> GetFilesById(params int[] id)
    {
        if (id.Length == 0)
            return [];
        var (nameList, arguments) = BuildIdList(id);
        var files = await db.QueryAsync(
            $"""
             select * from "ApplicationFiles"
             where "Id" in ({nameList})
             """, arguments,
            reader => reader.GetApplicationFile()
        );
        return files;
    }

    public async Task<List<Layout>> GetLayoutsById(params int[] id)
    {
        if (id.Length == 0)
            return [];

        var (nameList, arguments) = BuildIdList(id);
        var layouts = await db.QueryAsync(
            $"""
             select * from "Layouts"
             where "Id" in ({nameList})
             """, arguments,
            reader => reader.GetLayout()
        );
        return layouts;
    }

    public async Task<List<JobTemplateLayout>> GetJobTemplateLayouts(int id)
    {
        var jobLayouts = await db.QueryAsync(
            """
            select * from "JobTemplateLayouts" 
            where "JobTemplateId" = @JobId
            """,
            new Dictionary<string, object>
            {
                ["@JobId"] = id
            },
            reader => reader.GetJobTemplateLayout()
        );
        return jobLayouts;
    }
    public async Task<List<ApplicationImage>> GetImagesById(params int[] id)
    {
        if (id.Length == 0)
            return [];

        var (nameList, arguments) = BuildIdList(id);
        return await db.QueryAsync(
            $"""
             select * from "Images"
             where "Id" in ({nameList})
             """, arguments,
            reader => reader.GetApplicationImage()
        );
    }

    public async Task<List<JobTemplateLayoutAutoPosSettings>> GetAutoPosSettingsByJobTemplateLayoutId(params int[] id)
    {
        if (id.Length == 0)
            return [];

        var (nameList, arguments) = BuildIdList(id);
        return await db.QueryAsync(
            $"""
             select * from "JobTemplateLayoutAutoPosSettings"
             where "JobTemplateLayoutId" in ({nameList})
             """,
            arguments,
            reader => reader.GetAutoPosSettings()
        );
    }

    public async Task<List<JobTemplateLayoutAutoPosSettings>> GetAutoPosSettingsById(params int[] id)
    {
        if (id.Length == 0)
            return [];

        var (nameList, arguments) = BuildIdList(id);
        return await db.QueryAsync(
            $"""
             select * from "JobTemplateLayoutAutoPosSettings" 
             where "Id" in ({nameList})
             """,
            arguments,
            reader => reader.GetAutoPosSettings()
        );
    }

    public async Task<List<TemplateMatchingConfiguration>> GetTemplateMatchingConfigurationsById(params int[] id)
    {
        if (id.Length == 0)
            return [];

        var (nameList, arguments) = BuildIdList(id);
        return await db.QueryAsync(
            $"""
             select * from "TemplateMatchingConfiguration"
             where "Id" in ({nameList})
             """,
            arguments,
            reader => reader.GetTemplateMatchingConfiguration()
        );
    }
}