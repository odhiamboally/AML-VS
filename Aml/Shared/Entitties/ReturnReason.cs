using Aml.Channels.Clearing.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("RETURNREASON")]
public partial class ReturnReason
{
    public ReturnReason()
    {
        AmlCredits = new HashSet<AmlCredit>();
        InCheques = new HashSet<InCheque>();
        InCredits = new HashSet<InCredit>();
        InDebits = new HashSet<InDebit>();
        InRtgs = new HashSet<InRTG>();
        OutCheques = new HashSet<OutCheque>();
        OutCredits = new HashSet<OutCredit>();
        OutDebits = new HashSet<OutDebit>();
        OutRtgs = new HashSet<OutRtgs>();
    }

    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int ReturnReasonId { get; set; }

    [Required]
    [StringLength(255)]
    public string? ReturnReasonDesc { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<AmlCredit>? AmlCredits { get; set; }
    public virtual ICollection<InCheque>? InCheques { get; set; }
    public virtual ICollection<InCredit>? InCredits { get; set; }
    public virtual ICollection<InDebit>? InDebits { get; set; }
    public virtual ICollection<InRTG>? InRtgs { get; set; }
    public virtual ICollection<OutCheque>? OutCheques { get; set; }
    public virtual ICollection<OutCredit>? OutCredits { get; set; }
    public virtual ICollection<OutDebit>? OutDebits { get; set; }
    public virtual ICollection<OutRtgs>? OutRtgs { get; set; }

    public virtual Status? Status { get; set; }
}


