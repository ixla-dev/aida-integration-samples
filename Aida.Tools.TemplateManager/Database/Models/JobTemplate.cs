using Aida.Sdk.Model;

namespace Aida.Tools.TemplateManager.Database.Models;

public enum SupportSide
{
    Unknown = 0,
    Front   = 1,
    Rear    = -1,
}

public class JobTemplate
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string? Description { get; set; }
    public required DateTime? CreatedAt { get; set; }
    public required DateTime? UpdatedAt { get; set; }
    public required bool AutoPosEnabled { get; set; }
    public required int? FileId { get; set; }
    public required double ExpectedMarkDurationMs { get; set; }
    public required SupportSide FeedSide { get; set; }
    public required int? CardOrientationTemplateMatchingSettingsId { get; set; }

    public ApplicationFile? File { get; set; }
    public TemplateMatchingConfiguration? CardOrientationTemplateMatchingSettings { get; set; }
    public List<OcrInspection> OcrInspectionSettings { get; set; } = [];
    public List<JobTemplateLayout> Layouts { get; set; } = [];
}

public class OcrInspection
{
    public int Id { get; set; }
    public int JobTemplateId { get; set; }
    public int OcrSettingsId { get; set; }
    public SupportSide SupportSide { get; set; }
    public string ResultFieldName { get; set; }
    public bool RunBeforeMark { get; set; }
    public bool SendWebhookNotification { get; set; }
    public string Name { get; set; }
}

public class OcrSettings
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ScannerId { get; set; }
    public Rectangle Roi { get; set; }
    public PageSegmentationMode PageSegmentationMode { get; set; }
    public string WhiteList { get; set; }
    public string BlackList { get; set; }
    public int Multiply { get; set; }
    public int Threshold { get; set; }
    public string MatchPattern { get; set; }
    public double MeanConfidenceThreshold { get; set; }
    public string ImageAcquisitionPreset { get; set; }
    public string OutputResultFieldName { get; set; }
    public bool ValidateEntityValue { get; set; }
    public string ValidateEntityName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string CameraId { get; set; }
}