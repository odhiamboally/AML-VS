namespace Aml.Shared.Validations;

using Aml.Shared.Entitties;
using FluentValidation;

public class ValueDayValidator : AbstractValidator<ValueDay>
{
    public ValueDayValidator()
    {
        RuleFor(vd => vd.ValueDayCode)
            .NotEmpty().WithMessage("Value day code is required.")
            .Length(1, 5).WithMessage("Value day code must be between 1 and 5 characters.");

        RuleFor(vd => vd.ValueDayDesc)
            .NotEmpty().WithMessage("Value day description is required.");

        RuleFor(vd => vd.StatusId)
            .GreaterThan(0).WithMessage("Status ID must be greater than 0.");
    }
}

