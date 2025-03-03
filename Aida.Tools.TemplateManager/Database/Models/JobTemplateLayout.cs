namespace Aida.Tools.TemplateManager.Database.Models;

public class JobTemplateLayout
{
    public int Id { get; set; }
    public int JobTemplateId { get; set; }
    public int LayoutId { get; set; }
    public string SupportSide { get; set; }
    public List<JobTemplateLayoutAutoPosSettings> AutoPosSettings { get; set; } = [];
    public Layout Layout { get; set; }
}