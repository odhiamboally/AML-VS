using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("UPLOADBATCH")]

public class UploadBatch
{
    public int Id { get; set; }

    public string? Batch { get; set; }

    public int SessionId { get; set; }

    public int CurrencyId { get; set; }

    public string? Description { get; set; }

    public virtual Currency? Currency { get; set; }
}
