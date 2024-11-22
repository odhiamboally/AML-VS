using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("MENU")]
public class Menu
{
    public Menu()
    {
        AccessRights = new HashSet<AccessRight>();
    }

    public int MenuId { get; set; }

    [Required]
    [StringLength(50)]
    public string? MenuCode { get; set; }

    [Required]
    [StringLength(50)]
    public string? MenuName { get; set; }

    [Required]
    public string? MenuUrl { get; set; }

    public int MenuCategoryId { get; set; }

    public int MenuLevel { get; set; }

    public bool MainMenu { get; set; }

    public bool Functional { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<AccessRight> AccessRights { get; set; }

    public virtual MenuCategory MenuCategory { get; set; }

    public virtual Status? Status { get; set; }
}

