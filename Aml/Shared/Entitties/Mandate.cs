using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("MANDATE")]
public partial class Mandate
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal MandateId { get; set; }  // Updated to PascalCase

    [Required]
    public string? AccountNo { get; set; }  // Updated to PascalCase

    [Required]
    [StringLength(100)]
    public string? MandateName { get; set; }  // Updated to PascalCase

    public int? BranchId { get; set; }  // Updated to PascalCase

    [Required]
    public string? MandateText { get; set; }  // Updated to PascalCase

    [Required]
    public string? SignatureUrl { get; set; }  // Updated to PascalCase

    public byte[]? SignatureImage { get; set; }  // Updated to PascalCase

    public int StatusId { get; set; }  // Updated to PascalCase

    // Navigation property with PascalCase
    public virtual Status? Status { get; set; }  // Updated to PascalCase
}

