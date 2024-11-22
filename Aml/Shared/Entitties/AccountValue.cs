using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("ACCOUNTVALUE")]
public partial class AccountValue
{
    [Column(TypeName = "numeric")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal AccountValueId { get; set; }  // Using PascalCase for property name

    [Required]
    [StringLength(25)]
    public string? AccountNo { get; set; }  // Using PascalCase

    public int ValueDayId { get; set; }  // Using PascalCase

    public int StatusId { get; set; }  // Using PascalCase

    // Navigation properties with proper PascalCase
    public virtual Status? Status { get; set; }  // Association with Status entity
    public virtual ValueDay? ValueDay { get; set; }  // Association with ValueDay entity
}

