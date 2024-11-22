using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("ACHFILESTATUS")]
public partial class AchFileStatus
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal AchFileStatusId { get; set; }

    public string? AchFileName { get; set; }

    public int TranTypeId { get; set; }

    [Required]
    [StringLength(10)]
    public string? AchCodeId { get; set; }

    public DateTime CreateTime { get; set; }

    public virtual TranType? TranType { get; set; }
}

