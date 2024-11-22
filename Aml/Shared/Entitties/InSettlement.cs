using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("INSETTLEMENT")]
public partial class InSettlement
{
    [Column(TypeName = "numeric")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal InSettlementId { get; set; }

    public int BankId { get; set; }

    public int CurrencyId { get; set; }

    public int ClearingSessionId { get; set; }

    public int SettlementDataTypeId { get; set; }

    public int ItemCount { get; set; }

    public decimal ItemSum { get; set; }

    public int UserId { get; set; }

    [Column(TypeName = "timestamp")]
    [MaxLength(8)]
    [Timestamp]
    public byte[]? SysDate { get; set; }

    public DateTime? BackupDate { get; set; }

    public virtual Bank? Bank { get; set; }

    public virtual ClearingSession? ClearingSession { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual SettlementDataType? SettlementDataType { get; set; }

    public virtual User? User { get; set; }
}

