using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("CHEQUETEMP")]
public partial class ChequeTemp
{
    [Column(TypeName = "numeric")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal ChequeTempId { get; set; }

    [Column(TypeName = "numeric")]
    public decimal SlipId { get; set; }

    [Required]
    [StringLength(20)]
    public string? ProcNo { get; set; }

    [Required]
    public string? RawmLine { get; set; }

    public int Rejected { get; set; }

    public string? RejectReason { get; set; }

    public virtual Slip? Slip { get; set; }
}

