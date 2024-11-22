using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("UNUSEDCHEQUE")]
public partial class UnusedCheque
{
    [Key]
    [Column(Order = 0)]
    [StringLength(25)]
    public string? AccountNo { get; set; }

    [Column(Order = 1)]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int BranchId { get; set; }

    [Column(Order = 2)]
    [StringLength(20)]
    public string? ChequeNo { get; set; }

    [StringLength(20)]
    public string? ChequeBookNo { get; set; }

    [Column(Order = 3)]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Used { get; set; }

    public virtual Branch? Branch { get; set; }
}

