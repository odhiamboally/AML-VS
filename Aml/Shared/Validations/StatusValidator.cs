using Aml.Shared.Entitties;
using FluentValidation;
namespace Aml.Shared.Validations;

public class StatusValidator : AbstractValidator<Status>
{
    public StatusValidator()
    {
        RuleFor(x => x.StatusId)
            .NotEmpty().WithMessage("STATUSID is required.");

        RuleFor(x => x.StatusDesc)
            .NotEmpty().WithMessage("STATUSDESC is required.")
            .Length(1, 255).WithMessage("STATUSDESC length must be between 1 and 255 characters.");

        RuleForEach(x => x.AccessRights)
            .NotNull().WithMessage("ACCESSRIGHTs cannot be null.");

        RuleForEach(x => x.AccountTypes)
            .NotNull().WithMessage("ACCOUNTTYPEs cannot be null.");

        RuleForEach(x => x.AccountValues)
            .NotNull().WithMessage("ACCOUNTVALUEs cannot be null.");

        RuleForEach(x => x.AuditTrails)
            .NotNull().WithMessage("AUDITTRAILs cannot be null.");

        RuleForEach(x => x.Branches)
            .NotNull().WithMessage("BRANCHes cannot be null.");

        RuleForEach(x => x.ChargeExemptionClients)
            .NotNull().WithMessage("CHARGEEXEMPTIONCLIENTs cannot be null.");

        RuleForEach(x => x.ClearingCodes)
            .NotNull().WithMessage("CLEARINGCODEs cannot be null.");

        RuleForEach(x => x.ClearingSessions)
            .NotNull().WithMessage("CLEARINGSESSIONs cannot be null.");

        RuleForEach(x => x.Currencies)
            .NotNull().WithMessage("CURRENCies cannot be null.");

        RuleForEach(x => x.Holidays)
            .NotNull().WithMessage("HOLIDAYs cannot be null.");

        RuleForEach(x => x.LocationTypes)
            .NotNull().WithMessage("LOCATIONTYPEs cannot be null.");

        RuleForEach(x => x.MakerCheckers)
            .NotNull().WithMessage("MAKERCHECKERs cannot be null.");

        RuleForEach(x => x.Mandates)
            .NotNull().WithMessage("MANDATEs cannot be null.");

        RuleForEach(x => x.Menus)
            .NotNull().WithMessage("MENUs cannot be null.");

        RuleForEach(x => x.Profiles)
            .NotNull().WithMessage("PROFILEs cannot be null.");

        RuleForEach(x => x.Regions)
            .NotNull().WithMessage("REGIONs cannot be null.");

        RuleForEach(x => x.ReturnReasons)
            .NotNull().WithMessage("RETURNREASONs cannot be null.");

        RuleForEach(x => x.SecurityParams)
            .NotNull().WithMessage("SECURITYPARAMs cannot be null.");

        RuleForEach(x => x.SpsClients)
            .NotNull().WithMessage("SPSCLIENTs cannot be null.");

        RuleForEach(x => x.AccountTemp)
            .NotNull().WithMessage("ACCOUNT_TEMP cannot be null.");

        RuleForEach(x => x.SysConfigs)
            .NotNull().WithMessage("SYSCONGFIGs cannot be null.");

        RuleForEach(x => x.SysParams)
            .NotNull().WithMessage("SYSPARAMs cannot be null.");

        RuleForEach(x => x.TranTypes)
            .NotNull().WithMessage("TRANTYPEs cannot be null.");

        RuleForEach(x => x.UploadParams)
            .NotNull().WithMessage("UPLOADPARAMs cannot be null.");

        RuleForEach(x => x.Users)
            .NotNull().WithMessage("USERs cannot be null.");

        RuleForEach(x => x.ValueDays)
            .NotNull().WithMessage("VALUEDAYs cannot be null.");

        RuleForEach(x => x.Vouchers)
            .NotNull().WithMessage("VOUCHERs cannot be null.");
    }
}
