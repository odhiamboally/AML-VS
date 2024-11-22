using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class ReconStatusValidator : AbstractValidator<ReconStatus>
{
    public ReconStatusValidator()
    {
        RuleFor(rs => rs.ReconStatusName)
            .NotEmpty().WithMessage("Recon status name is required.")
            .Length(1, 20).WithMessage("Recon status name must be between 1 and 20 characters.");
    }
}

