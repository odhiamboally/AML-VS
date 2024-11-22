using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("ACHMESSAGE")]

public class AchMessage
{
    public decimal AchMessageId { get; set; }

    [Required]
    [StringLength(10)]
    public string? Remitter { get; set; }

    [Required]
    [StringLength(100)]
    public string? TrnRef { get; set; }

    [Required]
    public string? Remarks { get; set; }

    [Required]
    public string? AccountNo { get; set; }

    public decimal Amount { get; set; }

    public int CurrencyId { get; set; }

    public int UserId { get; set; }

    public int RtgsTypeId { get; set; }

    public DateTime? BackupDate { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual RtgsType? RtgsType { get; set; }

    public virtual User? User { get; set; }
}

