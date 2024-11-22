namespace Aml.Shared.Validations;

using Aml.Shared.Entitties;
using FluentValidation;

public class ChargeExemptionClientValidator : AbstractValidator<ChargeExemptionClient>
{
    public ChargeExemptionClientValidator()
    {
        RuleFor(cec => cec.ClientCode)
            .NotEmpty().WithMessage("Client Code is required.")
            .Length(4).WithMessage("Client Code must be exactly 4 characters.");

        RuleFor(cec => cec.ClientName)
            .NotEmpty().WithMessage("Client Name is required.");

        RuleFor(cec => cec.AccountNo)
            .NotEmpty().WithMessage("Account Number is required.")
            .Length(1, 20).WithMessage("Account Number must be between 1 and 20 characters.");

        RuleFor(cec => cec.StatusId)
            .GreaterThan(0).WithMessage("Status ID must be greater than 0.");
    }
}

