using Microsoft.EntityFrameworkCore;

namespace Aml.Shared.Entitties;

[Keyless]
public class AccountTemp
{
    public string? CustomerNo { get; set; }

    public string? AccountNo { get; set; }

    public string? AccountName { get; set; }

    public int CurrencyId { get; set; }

    public int BranchId { get; set; }

    public int StatusId { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public int UploadMethodId { get; set; }

    public bool AllowCredit { get; set; }

    public bool AllowDebit { get; set; }

    public string? NewAccount { get; set; }

    public string? AccountClass { get; set; }

    public DateTime? ReactivationDate { get; set; }

    public string? CreationDate { get; set; }

    public bool? ExemptAutoDelete { get; set; }

    public virtual Currency? Currency { get; set; }

    public virtual Status? Status { get; set; }
}

