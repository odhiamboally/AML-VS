using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("TRNSOURCE")]
public partial class TrnSource
{
    public TrnSource()
    {
        OutCredits = new HashSet<OutCredit>();
        OutDebits = new HashSet<OutDebit>();
        OutRtgs = new HashSet<OutRtgs>();
    }

    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int TrnSourceId { get; set; }

    [Required]
    [StringLength(25)]
    public string? TrnSourceName { get; set; }

    [Required]
    public string? TrnSourceDesc { get; set; }

    public virtual ICollection<OutCredit> OutCredits { get; set; }

    public virtual ICollection<OutDebit> OutDebits { get; set; }

    public virtual ICollection<OutRtgs> OutRtgs { get; set; }
}

