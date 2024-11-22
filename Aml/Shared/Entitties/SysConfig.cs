using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("SYSCONFIG")]
public partial class SysConfig
{
    public int SysConfigId { get; set; }  // Updated to PascalCase

    [Required]
    [StringLength(30)]
    public string? SysConfigName { get; set; }  // Updated to PascalCase

    [Required]
    public string? SysConfigValue { get; set; }  // Updated to PascalCase

    [Required]
    public string? SysConfigDesc { get; set; }  // Updated to PascalCase

    public int StatusId { get; set; }  // Updated to PascalCase

    // Navigation property with PascalCase
    public virtual Status? Status { get; set; }  // Updated to PascalCase
}

