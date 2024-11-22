using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("BATCH")]
public partial class Batch
{
    public Batch()
    {
        Incheques = new HashSet<InCheque>();
        InDebits = new HashSet<InDebit>();
        Outcredits = new HashSet<OutCredit>();
        Outdebits = new HashSet<OutDebit>();
        Salaries = new HashSet<Salary>();
        Slips = new HashSet<Slip>();
    }

    [Column(TypeName = "numeric")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal BatchId { get; set; }

    [Required]
    [StringLength(4)]
    public string? BatchNo { get; set; }

    public int BranchId { get; set; }

    public int CurrencyId { get; set; }

    public int BatchTypeId { get; set; }

    public int ClearingSessionId { get; set; }

    public int UserId { get; set; }

    public int? Verifier { get; set; }

    public int? Authorizer { get; set; }

    public bool Day2 { get; set; }

    public bool Captured { get; set; }

    public bool Verified { get; set; }

    public bool Authorized { get; set; }

    public bool Uploaded { get; set; }

    public bool Commissioned { get; set; }

    [Column(TypeName = "date")]
    public DateTime? BackupDate { get; set; }

    [Column(TypeName = "timestamp")]
    [MaxLength(8)]
    [Timestamp]
    public byte[]? SysDate { get; set; }

    public bool? Switched { get; set; }

    public bool? AchGenerated { get; set; }

    public virtual BatchType? BatchType { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual ClearingSession? ClearingSession { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual User? User { get; set; }

    public virtual ICollection<InCheque> Incheques { get; set; }

    public virtual ICollection<InDebit> InDebits { get; set; }

    public virtual ICollection<OutCredit> Outcredits { get; set; }

    public virtual ICollection<OutDebit> Outdebits { get; set; }

    public virtual ICollection<Salary> Salaries { get; set; }

    public virtual ICollection<Slip> Slips { get; set; }
}

