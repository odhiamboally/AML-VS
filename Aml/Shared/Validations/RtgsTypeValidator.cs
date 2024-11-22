using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class RtgsTypeValidator : AbstractValidator<RtgsType>
{
    public RtgsTypeValidator()
    {
        RuleFor(x => x.RtgsTypeId)
            .GreaterThan(0).WithMessage("RtgsTypeId must be greater than 0.");

        RuleFor(x => x.RtgsTypeName)
            .NotEmpty().WithMessage("RtgsTypeName is required.")
            .MaximumLength(25).WithMessage("RtgsTypeName cannot exceed 25 characters.");
    }
}

