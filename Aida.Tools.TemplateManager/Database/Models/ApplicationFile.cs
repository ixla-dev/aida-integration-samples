namespace Aida.Tools.TemplateManager.Database.Models;

public class ApplicationFile
{
    public required int Id { get; set; }
    public required string Filename { get; set; }
    public required string DisplayName { get; set; }
    public required long Size { get; set; }
    public required string OriginalFilename { get; set; }
    public required string Checksum { get; set; }
    public required string Location { get; set; }
    public required string Extension { get; set; }
    public required DateTime CreatedAt { get; set; }
    public required DateTime? UpdatedAt { get; set; }
    public required int FileBucketId { get; set; }
}