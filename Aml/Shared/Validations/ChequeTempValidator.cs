using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class ChequeTempValidator : AbstractValidator<ChequeTemp>
{
    public ChequeTempValidator()
    {
        RuleFor(c => c.ProcNo)
            .NotEmpty().WithMessage("Procedure number is required.")
            .Length(1, 20).WithMessage("Procedure number must be between 1 and 20 characters.");

        RuleFor(c => c.RawmLine)
            .NotEmpty().WithMessage("Raw machine line is required.");

        RuleFor(c => c.Rejected)
            .GreaterThanOrEqualTo(0).WithMessage("Rejected count must be non-negative.");

        RuleFor(c => c.RejectReason)
            .MaximumLength(500).WithMessage("Reject reason cannot exceed 500 characters.");
    }
}

