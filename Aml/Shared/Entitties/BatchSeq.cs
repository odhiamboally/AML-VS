using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("BATCHSEQ")]
public partial class BatchSeq
{
    public int BatchSeqId { get; set; }

    public int BranchId { get; set; }

    public int BatchSeed { get; set; }

    public int CurrentBatch { get; set; }

    public virtual Branch? Branch { get; set; }
}
