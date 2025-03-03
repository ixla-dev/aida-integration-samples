using System.ComponentModel.DataAnnotations;

namespace Aida.Tools.TemplateManager.Database;

public class DbHelperConfiguration
{
    [RegularExpression(@"^(?:[0-9]{1,3}\.){3}[0-9]{1,3}$")]
    [Required] public required string Host { get; set; }
    [Required] public required string Username { get; set; }
    [Required] public required string Password { get; set; }
}