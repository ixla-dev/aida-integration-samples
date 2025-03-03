namespace Aida.Tools.TemplateManager.Database.Models;

public class Layout
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string Name { get; set; }
    public int FileId { get; set; }
    public ApplicationFile File { get; set; }
}