using Aida.Sdk.Model;

namespace Aida.Tools.TemplateManager.Database.Models;

public class TemplateMatchingConfiguration
{
    public int Id { get; set; }
    public string? ScannerId { get; set; }
    public string? CameraId { get; set; }
    public string? Name { get; set; }
    public string? DisplayName { get; set; }
    public string? Description { get; set; }
    public string? AcquisitionPresetName { get; set; }
    public bool WarpPerspective { get; set; }
    public Rectangle SearchArea { get; set; }
    public Rectangle TemplateArea { get; set; }
    public float Threshold { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int SearchPatternImageId { get; set; }
    public ApplicationImage? SearchPatternImage { get; set; }
}