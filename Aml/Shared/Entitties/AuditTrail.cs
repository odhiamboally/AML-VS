using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("AUDITTRAIL")]

public class AuditTrail
{
    [Key]
    public decimal AuditId { get; set; }

    public int? UserId { get; set; }

    [Required]
    public string? ModuleName { get; set; }

    [Required]
    public string? AuditAction { get; set; }

    public DateTime AuditDate { get; set; }

    [Required]
    public string? WindowsUser { get; set; }

    [Required]
    public string? IpAddress { get; set; }

    [Required]
    public string? Workstation { get; set; }

    public int StatusId { get; set; }

    [Required]
    public string? HashCode { get; set; }

    [Column(TypeName = "timestamp")]
    [MaxLength(8)]
    [Timestamp]
    public byte[]? SysDate { get; set; }

    public virtual Status? Status { get; set; }

    public virtual User? User { get; set; }
}

