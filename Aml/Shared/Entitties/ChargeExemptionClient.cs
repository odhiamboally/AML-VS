using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("CHARGEEXEMPTIONCLIENT")]
public partial class ChargeExemptionClient
{
    public int ChargeExemptionClientId { get; set; }  // Updated to PascalCase

    [Required]
    [StringLength(4)]
    public string? ClientCode { get; set; }  // Updated to PascalCase

    [Required]
    public string? ClientName { get; set; }  // Updated to PascalCase

    [Required]
    [StringLength(20)]
    public string? AccountNo { get; set; }  // Updated to PascalCase

    public int StatusId { get; set; }  // Updated to PascalCase

    // Navigation property with PascalCase
    public virtual Status? Status { get; set; }  // Updated to PascalCase
}

