using System.Data;
using Aida.Tools.TemplateManager.Database.Models;
using Npgsql;
using ApplicationFile = Aida.Tools.TemplateManager.Database.Models.ApplicationFile;
using ApplicationImage = Aida.Tools.TemplateManager.Database.Models.ApplicationImage;
using JobTemplateLayoutAutoPosSettings = Aida.Tools.TemplateManager.Database.Models.JobTemplateLayoutAutoPosSettings;
using Rectangle = Aida.Sdk.Model.Rectangle;
using SupportSide = Aida.Tools.TemplateManager.Database.Models.SupportSide;
using TemplateMatchingConfiguration = Aida.Tools.TemplateManager.Database.Models.TemplateMatchingConfiguration;

namespace Aida.Tools.TemplateManager;

public static class DataReaderExtensions
{
    public static DateTime? GetNullableDateTime(this NpgsqlDataReader reader, string fieldName)
    {
        var col = reader.GetOrdinal(fieldName);
        return reader.IsDBNull(col) ? null : reader.GetDateTime(col);
    }

    public static bool GetNullableBoolean(this NpgsqlDataReader reader, string fieldName)
    {
        var col = reader.GetOrdinal(fieldName);
        return !reader.IsDBNull(col) && reader.GetBoolean(col);
    }

    public static string? GetNullableString(this NpgsqlDataReader reader, int index) => reader.IsDBNull(index) ? null : reader.GetString(index);

    public static string? GetNullableString(this NpgsqlDataReader reader, string fieldName)
    {
        var col = reader.GetOrdinal(fieldName);
        return reader.IsDBNull(col) ? null : reader.GetString(fieldName);
    }

    public static int GetNullableInt32(this NpgsqlDataReader reader, string fieldName)
    {
        var col = reader.GetOrdinal(fieldName);
        return reader.IsDBNull(col) ? default : reader.GetInt32(fieldName);
    }

    public static JobTemplateLayout GetJobTemplateLayout(this NpgsqlDataReader reader)
    {
        return new JobTemplateLayout
        {
            Id = reader.GetInt32(nameof(JobTemplateLayout.Id)),
            LayoutId = reader.GetInt32(nameof(JobTemplateLayout.LayoutId)),
            JobTemplateId = reader.GetInt32(nameof(JobTemplateLayout.JobTemplateId)),
            SupportSide = reader.GetString(nameof(JobTemplateLayout.SupportSide)),
        };
    }

    public static Layout GetLayout(this NpgsqlDataReader reader)
    {
        return new Layout
        {
            Id = reader.GetInt32(nameof(Layout.Id)),
            FileId = reader.GetInt32(nameof(Layout.FileId)),
            CreatedAt = reader.GetDateTime(nameof(Layout.CreatedAt)),
            UpdatedAt = reader.GetNullableDateTime(nameof(Layout.UpdatedAt)),
            Name = reader.GetString(nameof(Layout.Name)),
        };
    }

    public static ApplicationFile GetApplicationFile(this NpgsqlDataReader reader)
    {
        return new ApplicationFile
        {
            Id = reader.GetInt32(nameof(ApplicationFile.Id)),
            Filename = reader.GetString(nameof(ApplicationFile.Filename)),
            DisplayName = reader.GetString(nameof(ApplicationFile.DisplayName)),
            OriginalFilename = reader.GetString(nameof(ApplicationFile.OriginalFilename)),
            Checksum = reader.GetString(nameof(ApplicationFile.Checksum)),
            Size = reader.GetInt64(nameof(ApplicationFile.Size)),
            Location = reader.GetString(nameof(ApplicationFile.Location)),
            Extension = reader.GetString(nameof(ApplicationFile.Extension)),
            CreatedAt = reader.GetDateTime(nameof(ApplicationFile.CreatedAt)),
            UpdatedAt = reader.GetNullableDateTime(nameof(ApplicationFile.UpdatedAt)),
            FileBucketId = reader.GetInt32(nameof(ApplicationFile.FileBucketId)),
        };
    }

    public static JobTemplateLayoutAutoPosSettings GetAutoPosSettings(this NpgsqlDataReader reader)
    {
        return new JobTemplateLayoutAutoPosSettings
        {
            DisplayName = reader.GetString(nameof(JobTemplateLayoutAutoPosSettings.DisplayName)),
            Id = reader.GetInt32(nameof(JobTemplateLayoutAutoPosSettings.Id)),
            Index = reader.GetInt32(nameof(JobTemplateLayoutAutoPosSettings.Index)),
            JobTemplateLayoutId = reader.GetInt32(nameof(JobTemplateLayoutAutoPosSettings.JobTemplateLayoutId)),
            Threshold = reader.GetFloat(nameof(JobTemplateLayoutAutoPosSettings.Threshold)),
            TemplateMatchingConfigurationId = reader.GetInt32(nameof(JobTemplateLayoutAutoPosSettings.TemplateMatchingConfigurationId)),
        };
    }

    public static TemplateMatchingConfiguration GetTemplateMatchingConfiguration(this NpgsqlDataReader reader)
    {
        return new TemplateMatchingConfiguration
        {
            Id = reader.GetInt32(nameof(TemplateMatchingConfiguration.Id)),
            CameraId = reader.GetString(nameof(TemplateMatchingConfiguration.CameraId)),
            ScannerId = reader.GetString(nameof(TemplateMatchingConfiguration.ScannerId)),
            CreatedAt = reader.GetDateTime(nameof(TemplateMatchingConfiguration.CreatedAt)),
            UpdatedAt = reader.GetNullableDateTime(nameof(TemplateMatchingConfiguration.UpdatedAt)),
            Name = reader.GetNullableString(nameof(TemplateMatchingConfiguration.Name)),
            Description = reader.GetNullableString(nameof(TemplateMatchingConfiguration.Description)),
            Threshold = reader.GetFloat(nameof(TemplateMatchingConfiguration.Threshold)),
            WarpPerspective = reader.GetBoolean(nameof(TemplateMatchingConfiguration.WarpPerspective)),
            SearchPatternImageId = reader.GetNullableInt32(nameof(TemplateMatchingConfiguration.SearchPatternImageId)),
            TemplateArea = new Rectangle
            {
                Height = reader.GetInt32("TemplateArea_Height"),
                Width = reader.GetInt32("TemplateArea_Width"),
                X = reader.GetInt32("TemplateArea_X"),
                Y = reader.GetInt32("TemplateArea_Y"),
            },
            SearchArea = new Rectangle
            {
                Height = reader.GetInt32("SearchArea_Height"),
                Width = reader.GetInt32("SearchArea_Width"),
                X = reader.GetInt32("SearchArea_X"),
                Y = reader.GetInt32("SearchArea_Y"),
            }
        };
    }

    public static ApplicationImage GetApplicationImage(this NpgsqlDataReader reader)
    {
        return new ApplicationImage
        {
            Id = reader.GetInt32(nameof(ApplicationImage.Id)),
            FileId = reader.GetInt32(nameof(ApplicationImage.FileId)),
            TemplateMatchingConfigurationId = reader.GetNullableInt32(nameof(ApplicationImage.TemplateMatchingConfigurationId)),
            Height = reader.GetInt32(nameof(ApplicationImage.Height)),
            Width = reader.GetInt32(nameof(ApplicationImage.Width)),
            HorizontalResolution = reader.GetFloat(nameof(ApplicationImage.HorizontalResolution)),
            VerticalResolution = reader.GetFloat(nameof(ApplicationImage.VerticalResolution)),
            ImageFormat = reader.GetNullableString(nameof(ApplicationImage.ImageFormat)),
        };
    }

    public static JobTemplate GetJobTemplate(this NpgsqlDataReader reader)
    {
        return new JobTemplate
        {
            Id = reader.GetInt32(nameof(JobTemplate.Id)),
            Name = reader.GetString(nameof(JobTemplate.Name)),
            Description = reader.GetString(nameof(JobTemplate.Description)),
            FeedSide = (SupportSide)reader.GetInt32(nameof(JobTemplate.FeedSide)),
            CardOrientationTemplateMatchingSettingsId = reader.GetNullableInt32(nameof(JobTemplate.CardOrientationTemplateMatchingSettingsId)),
            AutoPosEnabled = reader.GetBoolean(nameof(JobTemplate.AutoPosEnabled)),
            CreatedAt = reader.GetNullableDateTime(nameof(JobTemplate.CreatedAt)),
            UpdatedAt = reader.GetNullableDateTime(nameof(JobTemplate.UpdatedAt)),
            FileId = reader.GetInt32(nameof(JobTemplate.FileId)),
            ExpectedMarkDurationMs = reader.GetDouble(nameof(JobTemplate.ExpectedMarkDurationMs)),
        };
    }

    public static Dictionary<string, object> ToDictionary(this NpgsqlDataReader reader)
    {
        var result = new Dictionary<string, object>();
        var cols   = reader.GetColumnSchema();
        foreach (var c in cols)
        {
            if (!c.ColumnOrdinal.HasValue) continue;
            result.Add(c.ColumnName, reader.GetValue(c.ColumnOrdinal.Value));
        }

        return result;
    }
}