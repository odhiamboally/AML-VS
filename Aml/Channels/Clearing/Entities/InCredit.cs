using Aml.Shared.Entitties;
using MassTransit;

namespace Aml.Channels.Clearing.Entities;

public partial class InCredit
{
    public decimal InCreditId { get; set; }
    public decimal BatchId { get; set; }
    public string? ProcNo { get; set; }
    public int UserId { get; set; }
    public int CustBranchId { get; set; }
    public string? CustAccount { get; set; }
    public string? CustName { get; set; }
    public int BankId { get; set; }
    public int BranchId { get; set; }
    public string? AccountNo { get; set; }
    public string? BeneficiaryName { get; set; }
    public string? OriginatorRef { get; set; }
    public int VoucherId { get; set; }
    public decimal Amount { get; set; }
    public int CurrencyId { get; set; }
    public int ClearingCodeId { get; set; }
    public string? Remarks { get; set; }
    public bool Captured { get; set; }
    public bool Authorized { get; set; }
    public bool Uploaded { get; set; }
    public bool Upload { get; set; }
    public bool Returned { get; set; }
    public int ReturnReasonId { get; set; }
    public DateTime? BackupDate { get; set; }
    public byte[]? SystDate { get; set; }
    public string? FileId { get; set; }
    public string? SourceRef { get; set; }
    public int FlagedClearingCodeId { get; set; }
    public DateTime? ValueDate { get; set; }
    public string? PmtTpInf { get; set; }
    public string? PmtTpInfCode { get; set; }
    public string? DrTwnNm { get; set; }
    public string? DrAdrLine { get; set; }
    public string? CrTwnNm { get; set; }
    public string? CrAdrLine { get; set; }
    public string? InstrId { get; set; }
    public string? EndToEndId { get; set; }
    public string? TxId { get; set; }
    public string? MsgId { get; set; }
    public string? CustAccountOrg { get; set; }
    public string? CustNameOrg { get; set; }
    public int? CbsPosted { get; set; }
    public string? UploadAttemptRef { get; set; }
    public string? AmlStatus { get; set; }

    public virtual Bank? Bank { get; set; }
    public virtual Branch? Branch { get; set; }
    public virtual ClearingCode? ClearingCode { get; set; }
    public virtual Currency? Currency { get; set; }
    public virtual ReturnReason? ReturnReason { get; set; }
    public virtual User? User { get; set; }
    public virtual Voucher? Voucher { get; set; }
}

