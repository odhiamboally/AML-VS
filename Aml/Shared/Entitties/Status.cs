using AutoMapper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Profile = Aml.Shared.Entitties.Profile;

namespace Aml.Shared.Entitties;

public partial class Status
{
    public Status()
    {
        AccessRights = new HashSet<AccessRight>();
        AccountTypes = new HashSet<AccountType>();
        AccountValues = new HashSet<AccountValue>();
        AuditTrails = new HashSet<AuditTrail>();
        Branches = new HashSet<Branch>();
        ChargeExemptionClients = new HashSet<ChargeExemptionClient>();
        ClearingCodes = new HashSet<ClearingCode>();
        ClearingSessions = new HashSet<ClearingSession>();
        Currencies = new HashSet<Currency>();
        Holidays = new HashSet<Holiday>();
        LocationTypes = new HashSet<LocationType>();
        MakerCheckers = new HashSet<MakerChecker>();
        Mandates = new HashSet<Mandate>();
        Menus = new HashSet<Menu>();
        Profiles = new HashSet<Profile>();
        Regions = new HashSet<Region>();
        ReturnReasons = new HashSet<ReturnReason>();
        SecurityParams = new HashSet<SecurityParam>();
        SpsClients = new HashSet<SpsClient>();
        AccountTemp = new HashSet<AccountTemp>();
        SysConfigs = new HashSet<SysConfig>();
        SysParams = new HashSet<SysParam>();
        TranTypes = new HashSet<TranType>();
        UploadParams = new HashSet<UploadParam>();
        Users = new HashSet<User>();
        ValueDays = new HashSet<ValueDay>();
        Vouchers = new HashSet<Voucher>();
    }

    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int StatusId { get; set; }

    [Required]
    public string? StatusDesc { get; set; }

    public virtual ICollection<AccessRight> AccessRights { get; set; }

    public virtual ICollection<AccountType> AccountTypes { get; set; }


    public virtual ICollection<AccountValue> AccountValues { get; set; }

    public virtual ICollection<AuditTrail> AuditTrails { get; set; }

    public virtual ICollection<Branch> Branches { get; set; }

    public virtual ICollection<ChargeExemptionClient> ChargeExemptionClients { get; set; }

    public virtual ICollection<ClearingCode> ClearingCodes { get; set; }

    public virtual ICollection<ClearingSession> ClearingSessions { get; set; }

    public virtual ICollection<Currency> Currencies { get; set; }

    public virtual ICollection<Holiday> Holidays { get; set; }

    public virtual ICollection<LocationType> LocationTypes { get; set; }

    public virtual ICollection<MakerChecker> MakerCheckers { get; set; }

    public virtual ICollection<Mandate> Mandates { get; set; }

    public virtual ICollection<Menu> Menus { get; set; }

    public virtual ICollection<Profile> Profiles { get; set; }

    public virtual ICollection<Region> Regions { get; set; }

    public virtual ICollection<ReturnReason> ReturnReasons { get; set; }

    public virtual ICollection<SecurityParam> SecurityParams { get; set; }

    public virtual ICollection<SpsClient> SpsClients { get; set; }

    [NotMapped]
    public virtual ICollection<AccountTemp> AccountTemp { get; set; }

    public virtual ICollection<SysConfig> SysConfigs { get; set; }

    public virtual ICollection<SysParam> SysParams { get; set; }

    public virtual ICollection<TranType> TranTypes { get; set; }

    public virtual ICollection<UploadParam> UploadParams { get; set; }

    public virtual ICollection<User> Users { get; set; }

    public virtual ICollection<ValueDay> ValueDays { get; set; }

    public virtual ICollection<Voucher> Vouchers { get; set; }
}

