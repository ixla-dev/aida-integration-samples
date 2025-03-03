using Aida.Sdk.Model;

namespace Aida.Tools.TemplateManager.Database.Models;

public class ScannerEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string DisplayName { get; set; }
    public int Index { get; set; }
    public EntityType Type { get; set; }
    public int MarkLoopCount { get; set; }
}