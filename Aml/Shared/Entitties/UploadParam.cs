using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("UPLOADPARAM")]
public partial class UploadParam
{
    public int UploadParamId { get; set; }

    public int BranchId { get; set; }

    public int CurrencyId { get; set; }

    [Required]
    [StringLength(25)]
    public string? OutChequeLedger { get; set; }

    [Required]
    [StringLength(20)]
    public string? OutChequeCode { get; set; }

    [Required]
    [StringLength(25)]
    public string? InChequeLedger { get; set; }

    [Required]
    [StringLength(20)]
    public string? InChequeCode { get; set; }

    [Required]
    [StringLength(25)]
    public string? OutRtgsLedger { get; set; }

    [Required]
    [StringLength(20)]
    public string? OutRtgsCode { get; set; }

    [Required]
    [StringLength(25)]
    public string? InRtgsLedger { get; set; }

    [Required]
    [StringLength(20)]
    public string? InRtgsCode { get; set; }

    [Required]
    [StringLength(25)]
    public string? OutCreditLedger { get; set; }

    [Required]
    [StringLength(20)]
    public string? OutCreditCode { get; set; }

    [Required]
    [StringLength(25)]
    public string? InCreditLedger { get; set; }

    [Required]
    [StringLength(20)]
    public string? InCreditCode { get; set; }

    [Required]
    [StringLength(25)]
    public string? OutDebitLedger { get; set; }

    [Required]
    [StringLength(20)]
    public string? OutDebitCode { get; set; }

    [Required]
    [StringLength(25)]
    public string? InDebitLedger { get; set; }

    [Required]
    [StringLength(20)]
    public string? InDebitCode { get; set; }

    [Required]
    [StringLength(25)]
    public string? InCpoLedger { get; set; }

    [Required]
    [StringLength(25)]
    public string? SuspenseAccount { get; set; }

    [Required]
    [StringLength(25)]
    public string? BranchAccHolderLedger { get; set; }

    public int StatusId { get; set; }

    [StringLength(50)]
    public string? OutCreditCommissionLedger { get; set; }

    [Column(TypeName = "money")]
    public decimal? OutCreditCharges { get; set; }

    [Column(TypeName = "money")]
    public decimal? OutDebitCharges { get; set; }

    [StringLength(25)]
    public string? IncomingUnpaidCharge { get; set; }

    [StringLength(50)]
    public string? IncomingUnpaidLedger { get; set; }

    [StringLength(50)]
    public string? IncomingUnpaidCode { get; set; }

    [StringLength(25)]
    public string? OutgoingUnpaidCharge { get; set; }

    [StringLength(50)]
    public string? OutgoingUnpaidLedger { get; set; }

    [StringLength(50)]
    public string? OutgoingUnpaidCode { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual Status? Status { get; set; }
}

