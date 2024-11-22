using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("BATCHTYPE")]
public partial class BatchType
{
    public BatchType()
    {
        Batches = new HashSet<Batch>();
        BatchMasters = new HashSet<BatchMaster>();
    }

    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int BatchTypeId { get; set; }

    [StringLength(3)]
    public string? BatchTypeCode { get; set; }

    public string? BatchTypeDesc { get; set; }

    public virtual ICollection<Batch> Batches { get; set; }

    public virtual ICollection<BatchMaster> BatchMasters { get; set; }
}

