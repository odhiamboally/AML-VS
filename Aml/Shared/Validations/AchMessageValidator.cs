using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class AchMessageValidator : AbstractValidator<AchMessage>
{
    public AchMessageValidator()
    {
        RuleFor(x => x.Remitter)
            .NotEmpty().WithMessage("Remitter is required.")
            .MaximumLength(10).WithMessage("Remitter cannot exceed 10 characters.");

        RuleFor(x => x.TrnRef)
            .NotEmpty().WithMessage("TrnRef is required.")
            .MaximumLength(100).WithMessage("TrnRef cannot exceed 100 characters.");

        RuleFor(x => x.Remarks)
            .NotEmpty().WithMessage("Remarks are required.");

        RuleFor(x => x.AccountNo)
            .NotEmpty().WithMessage("AccountNo is required.");

        RuleFor(x => x.Amount)
            .GreaterThan(0).WithMessage("Amount must be greater than 0.");

        RuleFor(x => x.CurrencyId)
            .GreaterThan(0).WithMessage("CurrencyId must be greater than 0.");

        RuleFor(x => x.UserId)
            .GreaterThan(0).WithMessage("UserId must be greater than 0.");

        RuleFor(x => x.RtgsTypeId)
            .GreaterThan(0).WithMessage("RtgsTypeId must be greater than 0.");
    }
}

