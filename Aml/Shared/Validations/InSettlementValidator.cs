using Aml.Shared.Entitties;
using FluentValidation;
namespace Aml.Shared.Validations;

public class InSettlementValidator : AbstractValidator<InSettlement>
{
    public InSettlementValidator()
    {
        RuleFor(i => i.BankId)
            .NotEmpty()
            .WithMessage("Bank ID is required.");

        RuleFor(i => i.CurrencyId)
            .NotEmpty()
            .WithMessage("Currency ID is required.");

        RuleFor(i => i.ClearingSessionId)
            .NotEmpty()
            .WithMessage("Clearing session ID is required.");

        RuleFor(i => i.SettlementDataTypeId)
            .NotEmpty()
            .WithMessage("Settlement data type ID is required.");

        RuleFor(i => i.ItemCount)
            .GreaterThan(0)
            .WithMessage("Item count must be greater than 0.");

        RuleFor(i => i.ItemSum)
            .GreaterThan(0)
            .WithMessage("Item sum must be greater than 0.");

        RuleFor(i => i.UserId)
            .NotEmpty()
            .WithMessage("User ID is required.");

        RuleFor(i => i.SysDate)
            .NotEmpty()
            .WithMessage("System date is required.");

        RuleFor(i => i.BackupDate)
            .NotEmpty()
            .WithMessage("Backup date is required.");
    }
}

