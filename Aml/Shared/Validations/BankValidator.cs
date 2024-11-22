using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class BankValidator : AbstractValidator<Bank>
{
    public BankValidator()
    {
        RuleFor(b => b.BankCode)
            .NotEmpty().WithMessage("BankCode is required.")
            .Length(1, 10).WithMessage("BankCode must be between 1 and 10 characters.");

        RuleFor(b => b.BankName)
            .NotEmpty().WithMessage("BankName is required.")
            .MaximumLength(100).WithMessage("BankName must not exceed 100 characters.");

        RuleFor(b => b.StatusId)
            .GreaterThan(0).WithMessage("StatusId must be greater than 0.");
    }
}
