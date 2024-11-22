using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("SECURITYPARAM")]
public partial class SecurityParam
{
    public int SecurityParamId { get; set; }  // Updated to PascalCase

    [Required]
    [StringLength(30)]
    public string? ParamName { get; set; }  // Updated to PascalCase

    [Required]
    public string? ParamValue { get; set; }  // Updated to PascalCase

    [Required]
    public string? ParamDesc { get; set; }  // Updated to PascalCase

    public int StatusId { get; set; }  // Updated to PascalCase

    // Navigation property with PascalCase
    public virtual Status? Status { get; set; }  // Updated to PascalCase
}

