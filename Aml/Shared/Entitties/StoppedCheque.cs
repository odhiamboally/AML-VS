using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("STOPPEDCHEQUE")]
public partial class StoppedCheque
{
    [Key]
    [Column(Order = 0)]
    [StringLength(20)]
    public string? StoppedChequeNo { get; set; }

    [Column(Order = 1)]
    [StringLength(25)]
    public string? AccountNo { get; set; }

    public DateTime? EffectiveDate { get; set; }

    [Column(Order = 2)]
    [StringLength(20)]
    public string? StartAt { get; set; }

    [Column(Order = 3)]
    [StringLength(20)]
    public string? EndAt { get; set; }

    [Column(Order = 4)]
    public decimal Amount { get; set; }

    [Column(Order = 5)]
    public string? CodeLine { get; set; }

    public DateTime? ExpiryDate { get; set; }

    [Column(Order = 6)]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int BranchId { get; set; }

    [Column(Order = 7)]
    public bool Manual { get; set; }

    public virtual Branch? Branch { get; set; }
}


