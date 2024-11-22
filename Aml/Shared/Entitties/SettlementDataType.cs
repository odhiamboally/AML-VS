using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("SETTLEMENTDATATYPE")]
public partial class SettlementDataType
{
    public SettlementDataType()
    {
        InSettlements = new HashSet<InSettlement>();
        OutSettlements = new HashSet<OutSettlement>();
    }

    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int SettlementDataTypeId { get; set; }

    [Required]
    [StringLength(50)]
    public string? TypeDescription { get; set; }

    [Required]
    [StringLength(2)]
    public string? TypeCode { get; set; }

    public virtual ICollection<InSettlement> InSettlements { get; set; }

    public virtual ICollection<OutSettlement> OutSettlements { get; set; }
}

