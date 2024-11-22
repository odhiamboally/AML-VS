using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("CATEGORY")]
public class Category
{
    public Category()
    {
        RuleConfigs = new HashSet<RuleConfig>();
    }

    public int CategoryId { get; set; }

    [StringLength(50)]
    public string? CategoryName { get; set; }

    [StringLength(50)]
    public string? CategoryValue { get; set; }

    [StringLength(100)]
    public string? CategoryDesc { get; set; }

    public virtual ICollection<RuleConfig> RuleConfigs { get; set; }
}

