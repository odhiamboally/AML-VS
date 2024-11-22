using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class OutSettlementValidator : AbstractValidator<OutSettlement>
{
    public OutSettlementValidator()
    {
        RuleFor(os => os.BankId)
            .NotEmpty().WithMessage("Bank ID is required.");

        RuleFor(os => os.CurrencyId)
            .NotEmpty().WithMessage("Currency ID is required.");

        RuleFor(os => os.ClearingSessionId)
            .NotEmpty().WithMessage("Clearing Session ID is required.");

        RuleFor(os => os.SettlementDataTypeId)
            .NotEmpty().WithMessage("Settlement Data Type ID is required.");

        RuleFor(os => os.ItemCount)
            .GreaterThan(0).WithMessage("Item count must be greater than zero.");

        RuleFor(os => os.ItemSum)
            .GreaterThan(0).WithMessage("Item sum must be greater than zero.");

        RuleFor(os => os.UserId)
            .NotEmpty().WithMessage("User ID is required.");

        RuleFor(os => os.SysDate)
            .NotEmpty().WithMessage("System Date is required.");

        RuleFor(os => os.BackupDate)
            .Must(BeAValidDate).WithMessage("Invalid backup date.");

    }

    private bool BeAValidDate(DateTime? date)
    {
        return date == null || date <= DateTime.UtcNow;
    }
}

