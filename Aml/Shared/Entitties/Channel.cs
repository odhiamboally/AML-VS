using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("CHANNEL")]
public class Channel
{
    public Channel()
    {
        RuleConfigs = new HashSet<RuleConfig>();
    }

    public int ChannelId { get; set; }

    [StringLength(20)]
    public string? ChannelName { get; set; }

    [StringLength(50)]
    public string? ChannelValue { get; set; }

    [StringLength(100)]
    public string? ChannelDesc { get; set; }

    public virtual ICollection<RuleConfig> RuleConfigs { get; set; }
}

