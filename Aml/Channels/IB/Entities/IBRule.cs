using System.ComponentModel.DataAnnotations;

namespace Aml.Channels.IB.Entities;

public class IBRule
{
    [Key]
    public int Id { get; set; }
    public string? Description { get; set; }
}
