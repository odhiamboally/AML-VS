using Aml.Channels.Clearing.Entities;
using MassTransit;
using Microsoft.AspNetCore.SignalR.Protocol;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("CURRENCY")]
public partial class Currency
{
    public Currency()
    {
        AccountTypes = new HashSet<AccountType>();
        AchCheques = new HashSet<AchCheque>();
        AchMessages = new HashSet<AchMessage>();
        AmlCredits = new HashSet<AmlCredit>();
        Batches = new HashSet<Batch>();
        RuleConfigs = new HashSet<RuleConfig>();
        AccountTemp = new HashSet<AccountTemp>();
        CpoReferences = new HashSet<CpoReference>();
        InCheques = new HashSet<InCheque>();
        InCredits = new HashSet<InCredit>();
        InDebits = new HashSet<InDebit>();
        InRtgs = new HashSet<InRTG>();
        InSettlements = new HashSet<InSettlement>();
        OutCheques = new HashSet<OutCheque>();
        OutCredits = new HashSet<OutCredit>();
        OutDebits = new HashSet<OutDebit>();
        OutRtgs = new HashSet<OutRtgs>();
        OutSettlements = new HashSet<OutSettlement>();
        Salaries = new HashSet<Salary>();
        UploadBatches = new HashSet<UploadBatch>();
        UploadParams = new HashSet<UploadParam>();
    }

    public int CurrencyId { get; set; }

    [Required]
    [StringLength(2)]
    public string? CurrencyCode { get; set; }

    [Required]
    public string? CurrencyName { get; set; }

    public string? UploadCode { get; set; }

    [StringLength(3)]
    public string? IsoCode { get; set; }

    [Column(TypeName = "money")]
    public decimal ValueCap { get; set; }

    public decimal ExchangeRate { get; set; }

    public bool RoundCents { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<AccountType> AccountTypes { get; set; }

    public virtual ICollection<AchCheque> AchCheques { get; set; }

    public virtual ICollection<AchMessage> AchMessages { get; set; }

    public virtual ICollection<AmlCredit> AmlCredits { get; set; }

    public virtual ICollection<Batch> Batches { get; set; }

    public virtual ICollection<RuleConfig> RuleConfigs { get; set; }

    [NotMapped]
    public virtual ICollection<AccountTemp> AccountTemp { get; set; }

    [NotMapped]
    public virtual ICollection<CpoReference> CpoReferences { get; set; }

    public virtual Status? Status { get; set; }

    public virtual ICollection<InCheque> InCheques { get; set; }

    public virtual ICollection<InCredit> InCredits { get; set; }

    public virtual ICollection<InDebit> InDebits { get; set; }

    public virtual ICollection<InRTG> InRtgs { get; set; }

    public virtual ICollection<InSettlement> InSettlements { get; set; }

    public virtual ICollection<OutCheque> OutCheques { get; set; }

    public virtual ICollection<OutCredit> OutCredits { get; set; }

    public virtual ICollection<OutDebit> OutDebits { get; set; }

    public virtual ICollection<OutRtgs> OutRtgs { get; set; }

    public virtual ICollection<OutSettlement> OutSettlements { get; set; }

    public virtual ICollection<Salary> Salaries { get; set; }

    public virtual ICollection<UploadBatch> UploadBatches { get; set; }

    public virtual ICollection<UploadParam> UploadParams { get; set; }
}

