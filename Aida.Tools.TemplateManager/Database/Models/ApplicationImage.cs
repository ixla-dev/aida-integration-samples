namespace Aida.Tools.TemplateManager.Database.Models;

public class ApplicationImage
{
    public int Id { get; set; }
    public int FileId { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public float HorizontalResolution { get; set; }
    public float VerticalResolution { get; set; }
    public string? ImageFormat { get; set; }
    public int? TemplateMatchingConfigurationId { get; set; }
    public ApplicationFile File { get; set; }
}