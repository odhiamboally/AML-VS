using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class ProfileValidator : AbstractValidator<Profile>
{
    public ProfileValidator()
    {
        // ProfileCode is required and must be exactly 5 characters
        RuleFor(p => p.ProfileCode)
            .NotEmpty().WithMessage("ProfileCode is required.")
            .Length(5).WithMessage("ProfileCode must be exactly 5 characters.");

        // ProfileName is required
        RuleFor(p => p.ProfileName)
            .NotEmpty().WithMessage("ProfileName is required.");

        // ProfileDesc is required
        RuleFor(p => p.ProfileDesc)
            .NotEmpty().WithMessage("ProfileDesc is required.");

        // StatusId must be a valid positive integer
        RuleFor(p => p.StatusId)
            .GreaterThan(0).WithMessage("StatusId must be greater than 0.");
    }
}
