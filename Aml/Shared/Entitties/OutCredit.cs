using MassTransit;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("OUTCREDIT")]
public partial class OutCredit
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal OutCreditId { get; set; }

    [Column(TypeName = "numeric")]
    public decimal BatchId { get; set; }

    [Required]
    [StringLength(20)]
    public string? ProcNo { get; set; }

    public int UserId { get; set; }

    public int CustBranchId { get; set; }

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
    public string? BeneficiaryName { get; set; }

    [Required]
    [StringLength(35)]
    public string? OriginatorRef { get; set; }

    public int VoucherId { get; set; }

    [Column(TypeName = "money")]
    public decimal Amount { get; set; }

    public int CurrencyId { get; set; }

    public int ClearingCodeId { get; set; }

    public int TrnSourceId { get; set; }

    public string? Remarks { get; set; }

    public bool Captured { get; set; }

    public bool Verified { get; set; }

    public bool Authorized { get; set; }

    public bool Uploaded { get; set; }

    public bool AchCreated { get; set; }

    public bool Upload { get; set; }

    public bool AchGenerate { get; set; }

    public bool Returned { get; set; }

    public int ReturnReasonId { get; set; }

    [Required]
    public string? FileId { get; set; }

    [Column(TypeName = "date")]
    public DateTime? BackupDate { get; set; }

    [Column(TypeName = "timestamp")]
    [MaxLength(8)]
    [Timestamp]
    public byte[]? SysDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ValueDate { get; set; }

    [StringLength(50)]
    public string? InstrId { get; set; }

    [StringLength(50)]
    public string? EndToEndId { get; set; }

    [StringLength(50)]
    public string? TxId { get; set; }

    [StringLength(50)]
    public string? MsgId { get; set; }

    public virtual Bank? Bank { get; set; }

    public virtual Batch? Batch { get; set; }

    public virtual Branch? Branch { get; set; }


    public virtual ClearingCode? ClearingCode { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual ReturnReason? ReturnReason { get; set; }

    public virtual TrnSource? TrnSource { get; set; }

    public virtual User? User { get; set; }

    public virtual Voucher? Voucher { get; set; }
}

