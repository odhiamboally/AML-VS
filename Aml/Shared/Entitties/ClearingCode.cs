using Aml.Channels.Clearing.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("CLEARINGCODE")]
public partial class ClearingCode
{
    public ClearingCode()
    {
        AchCheque = new HashSet<AchCheque>();
        AmlCredit = new HashSet<AmlCredit>();
        InCheque = new HashSet<InCheque>();
        InCredit = new HashSet<InCredit>();
        InDebit = new HashSet<InDebit>();
        OutCheque = new HashSet<OutCheque>();
        OutCredit = new HashSet<OutCredit>();
        OutDebit = new HashSet<OutDebit>();
    }

    public int ClearingCodeId { get; set; }

    [Required]
    [StringLength(5)]
    public string? ClearingCodeName { get; set; }

    [Required]
    public string? ClearingCodeDesc { get; set; }

    public int TranTypeId { get; set; }

    public bool UnpayCode { get; set; }

    public bool Representable { get; set; }

    public int StatusId { get; set; }

    [Column(TypeName = "money")]
    public decimal? InUnpayChargeUsd { get; set; }

    [Column(TypeName = "money")]
    public decimal? OutUnpayChargeUsd { get; set; }

    [Column(TypeName = "money")]
    public decimal? InUnpayCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? OutUnpayCharge { get; set; }

    [Column(TypeName = "money")]
    public decimal? InUnpayChargeEur { get; set; }

    [Column(TypeName = "money")]
    public decimal? OutUnpayChargeEur { get; set; }

    [Column(TypeName = "money")]
    public decimal? InUnpayChargeGbp { get; set; }

    [Column(TypeName = "money")]
    public decimal? OutUnpayChargeGbp { get; set; }

    public virtual ICollection<AchCheque> AchCheque { get; set; }
    public virtual ICollection<AmlCredit> AmlCredit { get; set; }
    public virtual Status? Status { get; set; }
    public virtual TranType? TranType { get; set; }
    public virtual ICollection<InCheque> InCheque { get; set; }
    public virtual ICollection<InCredit> InCredit { get; set; }
    public virtual ICollection<InDebit> InDebit { get; set; }
    public virtual ICollection<OutCheque> OutCheque { get; set; }
    public virtual ICollection<OutCredit> OutCredit { get; set; }
    public virtual ICollection<OutDebit> OutDebit { get; set; }
}

