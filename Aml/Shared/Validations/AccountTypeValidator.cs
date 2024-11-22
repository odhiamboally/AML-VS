using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class AccountTypeValidator : AbstractValidator<AccountType>
{
    public AccountTypeValidator()
    {
        RuleFor(x => x.AccountClass)
            .NotEmpty().WithMessage("AccountClass is required.")
            .MaximumLength(50).WithMessage("AccountClass cannot exceed 50 characters.");

        RuleFor(x => x.AccountTypeDesc)
            .MaximumLength(250).WithMessage("AccountTypeDesc cannot exceed 250 characters.");

        RuleFor(x => x.CurrencyId)
            .GreaterThan(0).When(x => x.CurrencyId.HasValue).WithMessage("CurrencyId must be greater than 0.");

        RuleFor(x => x.StatusId)
            .GreaterThan(0).When(x => x.StatusId.HasValue).WithMessage("StatusId must be greater than 0.");
    }
}

