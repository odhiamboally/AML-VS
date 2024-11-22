using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class MakerCheckerValidator : AbstractValidator<MakerChecker>
{
    public MakerCheckerValidator()
    {
        RuleFor(x => x.MakerCheckerId)
            .GreaterThan(0).WithMessage("MakerCheckerId must be greater than 0.");

        RuleFor(x => x.ObjectCategory)
            .GreaterThan(0).WithMessage("ObjectCategory must be greater than 0.");

        RuleFor(x => x.ObjectName)
            .NotEmpty().WithMessage("ObjectName is required.")
            .MaximumLength(30).WithMessage("ObjectName cannot exceed 30 characters.");

        RuleFor(x => x.ActionDescription)
            .NotEmpty().WithMessage("ActionDescription is required.");

        RuleFor(x => x.QueryString)
            .NotEmpty().WithMessage("QueryString is required.");

        RuleFor(x => x.HashCode)
            .NotEmpty().WithMessage("HashCode is required.");

        RuleFor(x => x.MakerId)
            .GreaterThan(0).WithMessage("MakerId must be greater than 0.");

        RuleFor(x => x.CheckerId)
            .GreaterThan(0).When(x => x.CheckerId.HasValue).WithMessage("CheckerId must be greater than 0 if present.");

        RuleFor(x => x.StatusId)
            .GreaterThan(0).WithMessage("StatusId must be greater than 0.");

        RuleFor(x => x.CheckerDate)
            .NotEmpty().WithMessage("CheckerDate is required.");

        RuleFor(x => x.SysDate)
            .NotNull().WithMessage("SysDate is required.");

        RuleFor(x => x.ActionReason)
            .NotEmpty().WithMessage("ActionReason is required.");
    }
}

