using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("SALARY")]
public partial class Salary
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal SalaryId { get; set; }

    [Required]
    public string? EmpName { get; set; }

    [Required]
    public string? EmpAccNo { get; set; }

    public decimal Amount { get; set; }

    public int BankId { get; set; }

    public int BranchId { get; set; }

    public DateTime SalaryDate { get; set; }

    [StringLength(30)]
    public string? RefNo { get; set; }

    public int RegionId { get; set; }

    public int CurrencyId { get; set; }

    public bool? IsRejected { get; set; }

    public string? RejectReason { get; set; }

    [Column(TypeName = "numeric")]
    public decimal ImportedFileId { get; set; }

    [Column(TypeName = "numeric")]
    public decimal BatchId { get; set; }

    public int UserId { get; set; }

    [Column(TypeName = "timestamp")]
    [MaxLength(8)]
    [Timestamp]
    public byte[]? SysDate { get; set; }

    [Required]
    [StringLength(20)]
    public string? ProcNo { get; set; }

    public DateTime? BackupDate { get; set; }

    public bool? Captured { get; set; }

    public bool? Verified { get; set; }

    public bool? Authorized { get; set; }

    public string? ClientName { get; set; }

    public string? ClientAccNo { get; set; }

    public int? SpsClientId { get; set; }

    public string? FileName { get; set; }

    public virtual Bank? Bank { get; set; }

    public virtual Batch? Batch { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual ImportedFile? ImportedFile { get; set; }

    public virtual Region? Region { get; set; }

    public virtual User? User { get; set; }
}
