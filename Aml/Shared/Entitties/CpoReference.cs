using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("CPOREFERENCE")]
[Keyless]
public class CpoReference
{
    public string? DdMicrNo { get; set; }

    public string? AccountNo { get; set; }

    public decimal Amount { get; set; }

    public decimal LcyAmount { get; set; }

    public int CurrencyId { get; set; }

    public string? InstrumentNo { get; set; }

    public string? Beneficiary { get; set; }

    public string? Narrative { get; set; }

    public virtual Currency? Currency { get; set; }
}

