using Aml.Channels.Clearing.Entities;
using MassTransit;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

public class Bank
{
    public Bank()
    {
        AchCheques = new HashSet<AchCheque>();
        AmlCredits = new HashSet<AmlCredit>();
        Branches = new HashSet<Branch>();
        InCheques = new HashSet<InCheque>();
        InCredits = new HashSet<InCredit>();
        InDebits = new HashSet<InDebit>();
        InRtgs = new HashSet<InRTG>();
        InSettlements = new HashSet<InSettlement>();
        OutCheques = new HashSet<OutCheque>();
        OutCredits = new HashSet<OutCredit>();
        OutDebits = new HashSet<OutDebit>();
        OutRtgs = new HashSet<OutRtgs>();
        OutSettlements = new HashSet<OutSettlement>();
        Salaries = new HashSet<Salary>();
    }

    public int BankId { get; set; }
    public string? BankCode { get; set; }
    public string? BankName { get; set; }
    public string? BankAbbrev { get; set; }
    public string? ClearingBankCode { get; set; }
    public string? UploadCode { get; set; }
    public bool Clearing { get; set; }
    public bool Fcy { get; set; }
    public int StatusId { get; set; }

    // Navigation properties
    public virtual ICollection<AchCheque> AchCheques { get; set; }
    public virtual ICollection<AmlCredit> AmlCredits { get; set; }
    public virtual ICollection<Branch> Branches { get; set; }
    public virtual ICollection<InCheque> InCheques { get; set; }
    public virtual ICollection<InCredit> InCredits { get; set; }
    public virtual ICollection<InDebit> InDebits { get; set; }
    public virtual ICollection<InRTG> InRtgs { get; set; }
    public virtual ICollection<InSettlement> InSettlements { get; set; }
    public virtual ICollection<OutCheque> OutCheques { get; set; }
    public virtual ICollection<OutCredit> OutCredits { get; set; }
    public virtual ICollection<OutDebit> OutDebits { get; set; }
    public virtual ICollection<OutRtgs> OutRtgs { get; set; }
    public virtual ICollection<OutSettlement> OutSettlements { get; set; }
    public virtual ICollection<Salary> Salaries { get; set; }
}
