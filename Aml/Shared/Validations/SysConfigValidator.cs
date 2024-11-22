namespace Aml.Shared.Validations;

using Aml.Shared.Entitties;
using FluentValidation;

public class SysConfigValidator : AbstractValidator<SysConfig>
{
    public SysConfigValidator()
    {
        RuleFor(sc => sc.SysConfigName)
            .NotEmpty().WithMessage("SysConfig Name is required.")
            .Length(1, 30).WithMessage("SysConfig Name must be between 1 and 30 characters.");

        RuleFor(sc => sc.SysConfigValue)
            .NotEmpty().WithMessage("SysConfig Value is required.");

        RuleFor(sc => sc.SysConfigDesc)
            .NotEmpty().WithMessage("SysConfig Description is required.");

        RuleFor(sc => sc.StatusId)
            .GreaterThan(0).WithMessage("Status ID must be greater than 0.");
    }
}

