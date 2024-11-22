using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("LOCATIONTYPE")]
public class LocationType
{
    public LocationType()
    {
        Branches = new HashSet<Branch>();
    }

    public int LocationTypeId { get; set; }

    [Required]
    [StringLength(5)]
    public string? LocationTypeCode { get; set; }

    [Required]
    [StringLength(255)] // Added a sensible max length for description
    public string? LocationTypeDesc { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<Branch> Branches { get; set; }

    public virtual Status? Status { get; set; }
}

