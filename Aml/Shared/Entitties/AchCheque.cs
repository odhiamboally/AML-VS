using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("ACHCHEQUE")]
public partial class AchCheque
{
    [Column(TypeName = "numeric")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal AchChequeId { get; set; }

    [Required]
    [StringLength(20)]
    public string? ProcNo { get; set; }

    [Required]
    public string? MLine { get; set; }

    public int UserId { get; set; }

    public int CustBranch { get; set; }

    [Required]
    [StringLength(25)]
    public string? CustAccount { get; set; }

    [Required]
    public string? CustName { get; set; }

    public int BankId { get; set; }

    public int BranchId { get; set; }

    [Required]
    [StringLength(25)]
    public string? AccountNo { get; set; }

    [Required]
    public string? AccountName { get; set; }

    [Required]
    [StringLength(15)]
    public string? ChequeNo { get; set; }

    public int VoucherId { get; set; }

    [Column(TypeName = "money")]
    public decimal Amount { get; set; }

    public int ClearingCodeId { get; set; }

    public int RegionId { get; set; }

    [Required]
    [StringLength(3)]
    public string? CheckDigit { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ValueDate { get; set; }

    public int CurrencyId { get; set; }

    public string? Remarks { get; set; }

    public string? FileName { get; set; }

    public string? TransRef { get; set; }

    [StringLength(100)]
    public string? FileId { get; set; }

    public int ClearingSessionId { get; set; }

    public bool Unpaid { get; set; }

    [Column(TypeName = "date")]
    public DateTime? BackupDate { get; set; }

    [Column(TypeName = "timestamp")]
    [MaxLength(8)]
    [Timestamp]
    public byte[]? SysDate { get; set; }

    [StringLength(50)]
    public string? InstructionId { get; set; }

    [StringLength(50)]
    public string? DrTwnNm { get; set; }

    [StringLength(50)]
    public string? DrAdrLine { get; set; }

    [StringLength(50)]
    public string? CrTwnNm { get; set; }

    [StringLength(50)]
    public string? CrAdrLine { get; set; }

    [StringLength(2)]
    public string? PmtTpInfCode { get; set; }

    [StringLength(1)]
    public string? PmtTpInf { get; set; }

    [StringLength(50)]
    public string? InstrId { get; set; }

    [StringLength(50)]
    public string? EndToEndId { get; set; }

    [StringLength(50)]
    public string? TxId { get; set; }

    [StringLength(50)]
    public string? MsgId { get; set; }

    public virtual Bank? Bank { get; set; }
    public virtual Branch? Branch { get; set; }
    public virtual ClearingCode? ClearingCode { get; set; }
    public virtual ClearingSession? ClearingSession { get; set; }
    public virtual Currency? Currency { get; set; }
    public virtual Region? Region { get; set; }
    public virtual User? User { get; set; }
    public virtual Voucher? Voucher { get; set; }
}
