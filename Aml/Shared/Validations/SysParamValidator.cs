namespace Aml.Shared.Validations;

using Aml.Shared.Entitties;
using FluentValidation;

public class SysParamValidator : AbstractValidator<SysParam>
{
    public SysParamValidator()
    {
        RuleFor(sp => sp.SysParamName)
            .NotEmpty().WithMessage("SysParam Name is required.")
            .Length(1, 30).WithMessage("SysParam Name must be between 1 and 30 characters.");

        RuleFor(sp => sp.SysParamValue)
            .NotEmpty().WithMessage("SysParam Value is required.");

        RuleFor(sp => sp.SysParamDesc)
            .NotEmpty().WithMessage("SysParam Description is required.");

        RuleFor(sp => sp.StatusId)
            .GreaterThan(0).WithMessage("Status ID must be greater than 0.");
    }
}

