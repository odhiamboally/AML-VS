using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("HOLIDAY")]

public class Holiday
{
    public int HolidayId { get; set; }

    [Required]
    [StringLength(50)]
    public string? HolidayName { get; set; }

    [Column(TypeName = "date")]
    public DateTime HolidayDate { get; set; }

    public bool LcyHoliday { get; set; }

    public bool FcyHoliday { get; set; }

    public bool Recurrent { get; set; }

    public int MakerId { get; set; }

    public int CheckerId { get; set; }

    public int StatusId { get; set; }

    public DateTime CheckerDate { get; set; }

    [Column(TypeName = "timestamp"), MaxLength(8)]
    [Timestamp]
    public byte[]? SysDate { get; set; }

    public virtual User? User { get; set; }

    public virtual Status? Status { get; set; }
}

