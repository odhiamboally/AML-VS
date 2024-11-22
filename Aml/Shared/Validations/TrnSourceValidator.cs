using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class TrnSourceValidator : AbstractValidator<TrnSource>
{
    public TrnSourceValidator()
    {
        RuleFor(t => t.TrnSourceName)
            .NotEmpty().WithMessage("Transaction source name is required.")
            .Length(1, 25).WithMessage("Transaction source name must be between 1 and 25 characters.");

        RuleFor(t => t.TrnSourceDesc)
            .NotEmpty().WithMessage("Transaction source description is required.");
    }
}

