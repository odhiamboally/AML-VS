using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class CurrencyValidator : AbstractValidator<Currency>
{
    public CurrencyValidator()
    {
        RuleFor(c => c.CurrencyCode)
            .NotEmpty()
            .WithMessage("Currency code is required.")
            .Length(2)
            .WithMessage("Currency code must be 2 characters.");

        RuleFor(c => c.CurrencyName)
            .NotEmpty()
            .WithMessage("Currency name is required.");

        RuleFor(c => c.ExchangeRate)
            .GreaterThan(0)
            .WithMessage("Exchange rate must be greater than zero.");

        RuleFor(c => c.ValueCap)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Value cap cannot be negative.");

        RuleFor(c => c.StatusId)
            .GreaterThan(0)
            .WithMessage("Status ID is required.");
    }
}

