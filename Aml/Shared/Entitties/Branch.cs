using Aml.Channels.Clearing.Entities;
using MassTransit;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aml.Shared.Entitties;

[Table("BRANCH")]
public partial class Branch
{
    public Branch()
    {
        AchCheques = new HashSet<AchCheque>();
        AmlCredits = new HashSet<AmlCredit>();
        Batches = new HashSet<Batch>();
        BatchMasters = new HashSet<BatchMaster>();
        BatchSequences = new HashSet<BatchSeq>();
        InCheques = new HashSet<InCheque>();
        InCredits = new HashSet<InCredit>();
        InDebits = new HashSet<InDebit>();
        InRtgs = new HashSet<InRTG>();
        OutCheques = new HashSet<OutCheque>();
        OutCredits = new HashSet<OutCredit>();
        OutDebits = new HashSet<OutDebit>();
        OutRtgs = new HashSet<OutRtgs>();
        Salaries = new HashSet<Salary>();
        Slips = new HashSet<Slip>();
        StoppedCheques = new HashSet<StoppedCheque>();
        UnusedCheques = new HashSet<UnusedCheque>();
        UploadParameters = new HashSet<UploadParam>();
        Users = new HashSet<User>();
    }

    public int BranchId { get; set; }
    public int BankId { get; set; }
    public string? BranchCode { get; set; }
    public string? BranchName { get; set; }
    public int LocationTypeId { get; set; }
    public int RegionId { get; set; }
    public string? UploadCode { get; set; }
    public bool IsHeadOffice { get; set; }
    public int StatusId { get; set; }

    // Navigation Properties
    public virtual Bank? Bank { get; set; }
    public virtual LocationType? LocationType { get; set; }
    public virtual Region? Region { get; set; }
    public virtual Status? Status { get; set; }
    public virtual ICollection<AchCheque> AchCheques { get; set; }
    public virtual ICollection<AmlCredit> AmlCredits { get; set; }
    public virtual ICollection<Batch> Batches { get; set; }
    public virtual ICollection<BatchMaster> BatchMasters { get; set; }
    public virtual ICollection<BatchSeq> BatchSequences { get; set; }
    public virtual ICollection<InCheque> InCheques { get; set; }
    public virtual ICollection<InCredit> InCredits { get; set; }
    public virtual ICollection<InDebit> InDebits { get; set; }
    public virtual ICollection<InRTG> InRtgs { get; set; }
    public virtual ICollection<OutCheque> OutCheques { get; set; }
    public virtual ICollection<OutCredit> OutCredits { get; set; }
    public virtual ICollection<OutDebit> OutDebits { get; set; }
    public virtual ICollection<OutRtgs> OutRtgs { get; set; }
    public virtual ICollection<Salary> Salaries { get; set; }
    public virtual ICollection<Slip> Slips { get; set; }
    public virtual ICollection<StoppedCheque> StoppedCheques { get; set; }
    public virtual ICollection<UnusedCheque> UnusedCheques { get; set; }
    public virtual ICollection<UploadParam> UploadParameters { get; set; }
    public virtual ICollection<User> Users { get; set; }
}

