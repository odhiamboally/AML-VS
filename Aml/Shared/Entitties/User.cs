using Aml.Channels.Clearing.Entities;
using MassTransit;
using Microsoft.AspNetCore.SignalR.Protocol;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Aml.Shared.Entitties;

[Table("USER")]
public partial class User
{
    public User()
    {
        AccessRights = new HashSet<AccessRight>();
        AchChequees = new HashSet<AchCheque>();
        AchMessages = new HashSet<AchMessage>();
        AmlCredits = new HashSet<AmlCredit>();
        AuditTrails = new HashSet<AuditTrail>();
        Batches = new HashSet<Batch>();
        BatchMasters = new HashSet<BatchMaster>();
        Holidays = new HashSet<Holiday>();
        InCheques = new HashSet<InCheque>();
        InCredits = new HashSet<InCredit>();
        InDebits = new HashSet<InDebit>();
        InRtgs = new HashSet<InRTG>();
        InSettlements = new HashSet<InSettlement>();
        MakerCheckers = new HashSet<MakerChecker>();
        OutCheques = new HashSet<OutCheque>();
        OutCredits = new HashSet<OutCredit>();
        OutDebits = new HashSet<OutDebit>();
        OutRtgs = new HashSet<OutRtgs>();
        OutSettlements = new HashSet<OutSettlement>();
        PasswordLists = new HashSet<PasswordList>();
        Salaries = new HashSet<Salary>();
    }

    public int UserId { get; set; }

    [Required]
    [StringLength(20)]
    public string? UserName { get; set; }

    [Required]
    [StringLength(30)]
    public string? Surname { get; set; }

    [Required]
    public string? OtherNames { get; set; }

    [Required]
    public string? Password { get; set; }

    [Required]
    public string? LoggedInSession { get; set; }

    [StringLength(50)]
    public string? Email { get; set; }

    [StringLength(20)]
    public string? PhoneNo { get; set; }

    public int BranchId { get; set; }

    public int StatusId { get; set; }

    public int ProfileId { get; set; }

    [Column(TypeName = "date")]
    public DateTime LastPassChange { get; set; }

    public bool ActiveSession { get; set; }

    public bool ChangePass { get; set; }

    [Column(TypeName = "date")]
    public DateTime LastLogin { get; set; }

    public int FailedAttempts { get; set; }

    [StringLength(100)]
    public string? TokenName { get; set; }

    public virtual ICollection<AccessRight> AccessRights { get; set; }

    public virtual ICollection<AchCheque> AchChequees { get; set; }

    public virtual ICollection<AchMessage> AchMessages { get; set; }

    public virtual ICollection<AmlCredit> AmlCredits { get; set; }

    public virtual ICollection<AuditTrail> AuditTrails { get; set; }

    public virtual ICollection<Batch> Batches { get; set; }

    public virtual ICollection<BatchMaster> BatchMasters { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual ICollection<Holiday> Holidays { get; set; }


    public virtual ICollection<InCheque> InCheques { get; set; }

    public virtual ICollection<InCredit> InCredits { get; set; }

    public virtual ICollection<InDebit> InDebits { get; set; }

    public virtual ICollection<InRTG> InRtgs { get; set; }

    public virtual ICollection<InSettlement> InSettlements { get; set; }

    public virtual ICollection<MakerChecker> MakerCheckers { get; set; }


    public virtual ICollection<OutCheque> OutCheques { get; set; }

    public virtual ICollection<OutCredit> OutCredits { get; set; }

    public virtual ICollection<OutDebit> OutDebits { get; set; }

    public virtual ICollection<OutRtgs> OutRtgs { get; set; }

    public virtual ICollection<OutSettlement> OutSettlements { get; set; }

    public virtual ICollection<PasswordList> PasswordLists { get; set; }

    public virtual Profile? Profile { get; set; }

    public virtual ICollection<Salary> Salaries { get; set; }

    public virtual Status? Status { get; set; }
}
