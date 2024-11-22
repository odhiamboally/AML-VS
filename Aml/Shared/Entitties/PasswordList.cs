using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("PASSWORDLIST")]

public class PasswordList
{
    public decimal PasswordListId { get; set; }

    public int UserId { get; set; }

    [Required]
    [StringLength(100)]
    public string? Password { get; set; }

    public DateTime ChangeDate { get; set; }

    public virtual User? User { get; set; }
}

