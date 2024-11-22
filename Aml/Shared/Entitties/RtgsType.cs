using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("RTGSTYPE")]

public class RtgsType
{
    public RtgsType()
    {
        AchMessages = new HashSet<AchMessage>();
        InRtgs = new HashSet<InRTG>();
        OutRtgs = new HashSet<OutRtgs>();
    }

    public int RtgsTypeId { get; set; }

    [Required]
    [StringLength(25)]
    public string? RtgsTypeName { get; set; }

    public virtual ICollection<AchMessage> AchMessages { get; set; }
    public virtual ICollection<InRTG> InRtgs { get; set; }
    public virtual ICollection<OutRtgs> OutRtgs { get; set; }
}

