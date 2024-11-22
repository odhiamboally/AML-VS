using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("PROFILE")]
public partial class Profile
{
    public Profile()
    {
        Users = new HashSet<User>();
    }

    public int ProfileId { get; set; }

    [Required]
    [StringLength(5)]
    public string? ProfileCode { get; set; }

    [Required]
    public string? ProfileName { get; set; }

    [Required]
    public string? ProfileDesc { get; set; }

    public int StatusId { get; set; }

    public virtual Status? Status { get; set; }

    public virtual ICollection<User> Users { get; set; }
}

