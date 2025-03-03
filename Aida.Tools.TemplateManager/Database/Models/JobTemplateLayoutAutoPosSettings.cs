namespace Aida.Tools.TemplateManager.Database.Models;

public class JobTemplateLayoutAutoPosSettings
{
    public int Id { get; set; }
    public int Index { get; set; }
    public float Threshold { get; set; }
    public string? DisplayName { get; set; }
    public int JobTemplateLayoutId { get; set; }
    public int TemplateMatchingConfigurationId { get; set; }
    public TemplateMatchingConfiguration? TemplateMatchingConfiguration { get; set; }
}