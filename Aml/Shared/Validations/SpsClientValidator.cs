namespace Aml.Shared.Validations;

using Aml.Shared.Entitties;
using FluentValidation;

public class SpsClientValidator : AbstractValidator<SpsClient>
{
    public SpsClientValidator()
    {
        RuleFor(sc => sc.ClientCode)
            .NotEmpty().WithMessage("Client code is required.")
            .Length(4).WithMessage("Client code must be exactly 4 characters.");

        RuleFor(sc => sc.ClientName)
            .NotEmpty().WithMessage("Client name is required.");

        RuleFor(sc => sc.AccountNo)
            .NotEmpty().WithMessage("Account number is required.")
            .Length(1, 20).WithMessage("Account number must be between 1 and 20 characters.");

        RuleFor(sc => sc.StatusId)
            .GreaterThan(0).WithMessage("Status ID must be greater than 0.");
    }
}

