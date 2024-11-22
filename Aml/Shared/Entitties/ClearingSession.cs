using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("CLEARINGSESSION")]
public partial class ClearingSession
{
    public ClearingSession()
    {
        AchCheque = new HashSet<AchCheque>();
        Batch = new HashSet<Batch>();
        InSettlement = new HashSet<InSettlement>();
        OutSettlement = new HashSet<OutSettlement>();
    }

    public int ClearingSessionId { get; set; }

    [StringLength(5)]
    public string? SessionCode { get; set; }

    public string? SessionName { get; set; }

    public TimeSpan? StartTime { get; set; }

    public TimeSpan? CutOffTime { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<AchCheque> AchCheque { get; set; }

    public virtual ICollection<Batch> Batch { get; set; }

    public virtual Status? Status { get; set; }

    public virtual ICollection<InSettlement> InSettlement { get; set; }

    public virtual ICollection<OutSettlement> OutSettlement { get; set; }
}

