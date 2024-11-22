using MassTransit;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("INDEBIT")]
public partial class InDebit
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal InDebitId { get; set; }

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

    [Required]
    [StringLength(20)]
    public string? Policy1 { get; set; }

    [Required]
    [StringLength(20)]
    public string? Policy2 { get; set; }

    [Column(TypeName = "date")]
    public DateTime SignDate { get; set; }

    public string? Remarks { get; set; }

    public bool Captured { get; set; }

    public bool Authorized { get; set; }

    public bool Uploaded { get; set; }

    public bool Upload { get; set; }

    public bool Returned { get; set; }

    public int ReturnReasonId { get; set; }

    [Column(TypeName = "date")]
    public DateTime? BackupDate { get; set; }

    [Column(TypeName = "timestamp")]
    [MaxLength(8)]
    [Timestamp]
    public byte[]? SysDate { get; set; }

    [StringLength(50)]
    public string? FileId { get; set; }

    [Required]
    [StringLength(20)]
    public string? SourceRef { get; set; }

    public int FlaggedClearingCodeId { get; set; }

    public bool Flagged { get; set; }

    public bool RejectionAuthorized { get; set; }

    public bool MarkedForRejection { get; set; }

    public bool RejectionUploaded { get; set; }

    public int UnpayCodeId { get; set; }

    [StringLength(1)]
    public string? PmtTpInf { get; set; }

    [StringLength(2)]
    public string? PmtTpInfCode { get; set; }

    [StringLength(50)]
    public string? DrTwnNm { get; set; }

    [StringLength(50)]
    public string? DrAdrLine { get; set; }

    [StringLength(50)]
    public string? CrTwnNm { get; set; }

    [StringLength(50)]
    public string? CrAdrLine { get; set; }

    [StringLength(50)]
    public string? MndtId { get; set; }

    [StringLength(50)]
    public string? DtOfSgntr { get; set; }

    [StringLength(50)]
    public string? FnlColltnDt { get; set; }

    [StringLength(50)]
    public string? Frqcy { get; set; }

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

    [StringLength(25)]
    public string? CustAccountOrg { get; set; }

    public string? CustNameOrg { get; set; }

    public virtual Bank? Bank { get; set; }

    public virtual Batch? Batch { get; set; }

    public virtual Branch? Branch { get; set; }


    public virtual ClearingCode? ClearingCode { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual ReturnReason? ReturnReason { get; set; }

    public virtual User? User { get; set; }

    public virtual Voucher? Voucher { get; set; }
}

