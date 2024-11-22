using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("REGION")]
public partial class Region
{
    public Region()
    {
        Achcheques = new HashSet<AchCheque>();
        Branches = new HashSet<Branch>();
        Incheques = new HashSet<InCheque>();
        Outcheques = new HashSet<OutCheque>();
        Salaries = new HashSet<Salary>();
    }

    public int RegionId { get; set; }

    [Required]
    [StringLength(5)]
    public string RegionCode { get; set; }

    [Required]
    public string RegionName { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<AchCheque> Achcheques { get; set; }

    public virtual ICollection<Branch> Branches { get; set; }

    public virtual ICollection<InCheque> Incheques { get; set; }

    public virtual ICollection<OutCheque> Outcheques { get; set; }

    public virtual Status Status { get; set; }

    public virtual ICollection<Salary> Salaries { get; set; }
}
