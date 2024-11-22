using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;


[Table("MENUCATEGORY")]
public class MenuCategory
{
    public MenuCategory()
    {
        Menus = new HashSet<Menu>();
    }

    public int MenuCategoryId { get; set; }

    [Required]
    [StringLength(25)]
    public string? MenuCategoryName { get; set; }

    public virtual ICollection<Menu> Menus { get; set; }
}

