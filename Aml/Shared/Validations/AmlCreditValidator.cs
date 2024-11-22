using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class AmlCreditValidator : AbstractValidator<AmlCredit>
{
    public AmlCreditValidator()
    {
        RuleFor(a => a.ProcNo)
            .NotEmpty().WithMessage("ProcNo is required")
            .Length(1, 20).WithMessage("ProcNo length must be between 1 and 20 characters");

        RuleFor(a => a.CustAccount)
            .NotEmpty().WithMessage("Customer account is required")
            .Length(1, 25).WithMessage("Customer account length must be between 1 and 25 characters");

        RuleFor(a => a.CustName)
            .NotEmpty().WithMessage("Customer name is required");

        RuleFor(a => a.AccountNo)
            .NotEmpty().WithMessage("Account number is required")
            .Length(1, 25).WithMessage("Account number length must be between 1 and 25 characters");

        RuleFor(a => a.Amount)
            .GreaterThan(0).WithMessage("Amount must be greater than 0");

        RuleFor(a => a.CurrencyId)
            .GreaterThan(0).WithMessage("Currency ID must be greater than 0");

        RuleFor(a => a.ClearingCodeId)
            .GreaterThan(0).WithMessage("Clearing code ID must be greater than 0");

        RuleFor(a => a.SourceRef)
            .NotEmpty().WithMessage("Source reference is required")
            .Length(1, 20).WithMessage("Source reference length must be between 1 and 20 characters");

        RuleFor(a => a.FlaggedClearingCodeId)
            .GreaterThan(0).WithMessage("Flagged clearing code ID must be greater than 0");
    }
}
