namespace Aml.Shared.Validations;

using Aml.Shared.Entitties;
using FluentValidation;

public class SecurityParamValidator : AbstractValidator<SecurityParam>
{
    public SecurityParamValidator()
    {
        RuleFor(sp => sp.ParamName)
            .NotEmpty().WithMessage("Parameter name is required.")
            .Length(1, 30).WithMessage("Parameter name must be between 1 and 30 characters.");

        RuleFor(sp => sp.ParamValue)
            .NotEmpty().WithMessage("Parameter value is required.");

        RuleFor(sp => sp.ParamDesc)
            .NotEmpty().WithMessage("Parameter description is required.");

        RuleFor(sp => sp.StatusId)
            .GreaterThan(0).WithMessage("Status ID must be greater than 0.");
    }
}

