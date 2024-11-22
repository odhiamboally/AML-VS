using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("OUTCHEQUE")]
public partial class OutCheque
{
    [Column(TypeName = "numeric")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal OutChequeId { get; set; }

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

    public bool Manual { get; set; }

    public int ClearingCodeId { get; set; }

    public int RegionId { get; set; }

    [Required]
    [StringLength(3)]
    public string? CheckDigit { get; set; }

    [Column(TypeName = "date")]
    public DateTime? ValueDate { get; set; }

    public int CurrencyId { get; set; }

    [Column(TypeName = "numeric")]
    public decimal SlipId { get; set; }

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
    public DateTime? BackUpDate { get; set; }

    [Column(TypeName = "timestamp")]
    [MaxLength(8)]
    [Timestamp]
    public byte[]? SysTDate { get; set; }

    [Column(TypeName = "date")]
    public DateTime? DepositDate { get; set; }

    public string? PayeeName { get; set; }

    public string? DepositorContact { get; set; }

    [StringLength(50)]
    public string? InstructionId { get; set; }

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

    public virtual Currency? Currency { get; set; }

    public virtual Region? Region { get; set; }

    public virtual ReturnReason? ReturnReason { get; set; }

    public virtual Slip? Slip { get; set; }

    public virtual User? User { get; set; }

    public virtual Voucher? Voucher { get; set; }
}

