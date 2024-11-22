using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("VALUEDAY")]
public partial class ValueDay
{
    public ValueDay()
    {
        AccountValues = new HashSet<AccountValue>();  // Correct PascalCase for collection
    }

    public int ValueDayId { get; set; }  // PascalCase for property name

    [Required]
    [StringLength(5)]
    public string? ValueDayCode { get; set; }  // PascalCase

    [Required]
    public string? ValueDayDesc { get; set; }  // PascalCase

    public int StatusId { get; set; }  // PascalCase

    // Navigation properties with proper PascalCase
    public virtual ICollection<AccountValue> AccountValues { get; set; }  // Collection navigation with PascalCase
    public virtual Status? Status { get; set; }  // Association with Status entity
}

