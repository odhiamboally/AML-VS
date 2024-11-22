using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("ACCOUNTTYPE")]
public class AccountType
{
    [Key]
    public int AccountTypeId { get; set; }

    [Required]
    public string? AccountClass { get; set; }

    public string? AccountTypeDesc { get; set; }

    public int? CurrencyId { get; set; }

    public int? StatusId { get; set; }

    public virtual Currency? Currency { get; set; }


    public virtual Status? Status { get; set; }

}

