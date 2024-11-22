using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class AuditTrailValidator : AbstractValidator<AuditTrail>
{
    public AuditTrailValidator()
    {
        RuleFor(x => x.AuditId)
            .GreaterThan(0).WithMessage("AuditId must be greater than 0.");

        RuleFor(x => x.ModuleName)
            .NotEmpty().WithMessage("ModuleName is required.");

        RuleFor(x => x.AuditAction)
            .NotEmpty().WithMessage("AuditAction is required.");

        RuleFor(x => x.AuditDate)
            .NotEmpty().WithMessage("AuditDate is required.");

        RuleFor(x => x.WindowsUser)
            .NotEmpty().WithMessage("WindowsUser is required.");

        RuleFor(x => x.IpAddress)
            .NotEmpty().WithMessage("IpAddress is required.");

        RuleFor(x => x.Workstation)
            .NotEmpty().WithMessage("Workstation is required.");

        RuleFor(x => x.StatusId)
            .GreaterThan(0).WithMessage("StatusId must be greater than 0.");

        RuleFor(x => x.HashCode)
            .NotEmpty().WithMessage("HashCode is required.");

        RuleFor(x => x.SysDate)
            .NotNull().WithMessage("SysDate is required.");
    }
}

