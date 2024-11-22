using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("SLIP")]
public partial class Slip
{
    public Slip()
    {
        ChequeTemps = new HashSet<ChequeTemp>();
        OutCheques = new HashSet<OutCheque>();
    }

    [Column(TypeName = "numeric")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal SlipId { get; set; }

    [Required]
    [StringLength(4)]
    public string? SlipNo { get; set; }

    [Column(TypeName = "numeric")]
    public decimal BatchId { get; set; }

    public int CustBranchId { get; set; }

    [Required]
    [StringLength(25)]
    public string? CustAccount { get; set; }

    public int ItemCount { get; set; }

    [Column(TypeName = "money")]
    public decimal ItemSum { get; set; }

    public string? Remarks { get; set; }

    public bool Bulk { get; set; }

    public bool Captured { get; set; }

    public bool Verified { get; set; }

    public bool Authorized { get; set; }

    public bool Uploaded { get; set; }

    [Column(TypeName = "date")]
    public DateTime? BackupDate { get; set; }

    [Column(TypeName = "timestamp")]
    [MaxLength(8)]
    [Timestamp]
    public byte[]? SystDate { get; set; }

    public virtual Batch? Batch { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual ICollection<ChequeTemp> ChequeTemps { get; set; }

    public virtual ICollection<OutCheque> OutCheques { get; set; }
}

