using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("RECONSTATUS")]
public partial class ReconStatus
{
    public ReconStatus()
    {
        Incheques = new HashSet<InCheque>();
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int ReconStatusId { get; set; }

    [Required]
    [StringLength(20)]
    public string? ReconStatusName { get; set; }

    public virtual ICollection<InCheque> Incheques { get; set; }
}

