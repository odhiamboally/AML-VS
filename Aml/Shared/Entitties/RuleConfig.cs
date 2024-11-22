using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Channels;

namespace Aml.Shared.Entitties;

[Table("RULECONFIG")]
public class RuleConfig
{
    [Key]
    public int RuleNo { get; set; }

    public string? RuleCode { get; set; }

    public string? RuleDesc { get; set; }

    public string? RuleName { get; set; }

    public string? DisplayColumn { get; set; }

    public string? Condition { get; set; }

    public string? RuleSource { get; set; }

    public bool Functional { get; set; }

    public string? Entity { get; set; }

    public int? CategoryId { get; set; }

    public int? ChannelId { get; set; }

    public int? CurrencyId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Channel? Channel { get; set; }

    public virtual Currency? Currency { get; set; }
}

