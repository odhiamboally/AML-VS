using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("SYSPARAM")]
public partial class SysParam
{
    public int SysParamId { get; set; }  // Updated to PascalCase

    [Required]
    [StringLength(30)]
    public string? SysParamName { get; set; }  // Updated to PascalCase

    [Required]
    public string? SysParamValue { get; set; }  // Updated to PascalCase

    [Required]
    public string? SysParamDesc { get; set; }  // Updated to PascalCase

    public int StatusId { get; set; }  // Updated to PascalCase

    // Navigation property with PascalCase
    public virtual Status? Status { get; set; }  // Updated to PascalCase
}
