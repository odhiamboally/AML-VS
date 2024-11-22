using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("BATCHMASTER")]
public partial class BatchMaster
{
    [Column(TypeName = "numeric")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal BatchMasterId { get; set; }

    public int BranchId { get; set; }

    [Required]
    [StringLength(4)]
    public string? BatchNo { get; set; }

    public int BatchTypeId { get; set; }

    public int UserId { get; set; }

    public virtual BatchType? BatchType { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual User? User { get; set; }
}

