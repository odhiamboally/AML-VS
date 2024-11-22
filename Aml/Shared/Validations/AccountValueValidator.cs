namespace Aml.Shared.Validations;

using Aml.Shared.Entitties;
using FluentValidation;

public class AccountValueValidator : AbstractValidator<AccountValue>
{
    public AccountValueValidator()
    {
        RuleFor(av => av.AccountNo)
            .NotEmpty().WithMessage("Account number is required.")
            .Length(1, 25).WithMessage("Account number must be between 1 and 25 characters.");

        RuleFor(av => av.ValueDayId)
            .GreaterThan(0).WithMessage("Value day ID must be greater than 0.");

        RuleFor(av => av.StatusId)
            .GreaterThan(0).WithMessage("Status ID must be greater than 0.");
    }
}

