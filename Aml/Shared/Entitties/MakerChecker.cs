using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("MAKERCHECKER")]
public class MakerChecker
{
    public decimal MakerCheckerId { get; set; }

    public int ObjectCategory { get; set; }

    [Required]
    [StringLength(30)]
    public string? ObjectName { get; set; }

    [Required]
    public string? ActionDescription { get; set; }

    [Required]
    public string? QueryString { get; set; }

    [Required]
    public string? HashCode { get; set; }

    public int MakerId { get; set; }

    public int? CheckerId { get; set; }

    public int StatusId { get; set; }

    public DateTime CheckerDate { get; set; }

    [Column(TypeName = "timestamp")]
    [MaxLength(8)]
    [Timestamp]
    public byte[]? SysDate { get; set; }

    [Required]
    public string? ActionReason { get; set; }

    public virtual User? User { get; set; }


    public virtual Status? Status { get; set; }
}

