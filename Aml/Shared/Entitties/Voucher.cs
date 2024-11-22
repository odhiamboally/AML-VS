using Aml.Channels.Clearing.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("Voucher")]
public partial class Voucher
{
    public Voucher()
    {
        AchChequeList = new HashSet<AchCheque>();
        AmlCreditList = new HashSet<AmlCredit>();
        InChequeList = new HashSet<InCheque>();
        InCreditList = new HashSet<InCredit>();
        InDebitList = new HashSet<InDebit>();
        OutChequeList = new HashSet<OutCheque>();
        OutCreditList = new HashSet<OutCredit>();
        OutDebitList = new HashSet<OutDebit>();
    }

    public int VoucherId { get; set; }

    [Required]
    [StringLength(5)]
    public string? VoucherCode { get; set; }

    [Required]
    public string? VoucherName { get; set; }

    public int TranTypeId { get; set; }

    public int StatusId { get; set; }

    public virtual ICollection<AchCheque> AchChequeList { get; set; }

    public virtual ICollection<AmlCredit> AmlCreditList { get; set; }

    public virtual ICollection<InCheque> InChequeList { get; set; }

    public virtual ICollection<InCredit> InCreditList { get; set; }

    public virtual ICollection<InDebit> InDebitList { get; set; }

    public virtual ICollection<OutCheque> OutChequeList { get; set; }

    public virtual ICollection<OutCredit> OutCreditList { get; set; }

    public virtual ICollection<OutDebit> OutDebitList { get; set; }

    public virtual Status? Status { get; set; }

    public virtual TranType? TranType { get; set; }

}