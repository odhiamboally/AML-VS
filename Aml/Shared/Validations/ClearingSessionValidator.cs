using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class ClearingSessionValidator : AbstractValidator<ClearingSession>
{
    public ClearingSessionValidator()
    {
        RuleFor(cs => cs.SessionCode)
            .Length(1, 5).WithMessage("Session Code must be between 1 and 5 characters.");

        RuleFor(cs => cs.SessionName)
            .NotEmpty().WithMessage("Session Name is required.");

        RuleFor(cs => cs.StartTime)
            .NotNull().WithMessage("Start Time is required.");

        RuleFor(cs => cs.CutOffTime)
            .NotNull().WithMessage("Cut Off Time is required.");

        RuleFor(cs => cs.StatusId)
            .GreaterThan(0).WithMessage("Status must be selected.");
    }
}

