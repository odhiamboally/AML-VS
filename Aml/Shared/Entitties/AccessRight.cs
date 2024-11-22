
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("ACCESSRIGHT")]
public class AccessRight
{
    [Column(TypeName = "numeric")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public decimal AccessRightId { get; set; }

    public int ProfileId { get; set; }

    public int MenuId { get; set; }

    public int StatusId { get; set; }

    public int UserId { get; set; }

    public virtual Menu? Menu { get; set; }

    public virtual Status? Status { get; set; }

    public virtual User? User { get; set; }
}

