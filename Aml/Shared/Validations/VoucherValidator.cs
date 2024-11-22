using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class VoucherValidator : AbstractValidator<Voucher>
{
    public VoucherValidator()
    {
        RuleFor(v => v.VoucherCode)
            .NotEmpty().WithMessage("Voucher code is required.")
            .Length(1, 5).WithMessage("Voucher code must be between 1 and 5 characters.");

        RuleFor(v => v.VoucherName)
            .NotEmpty().WithMessage("Voucher name is required.");

        RuleFor(v => v.TranTypeId)
            .GreaterThan(0).WithMessage("Transaction type ID must be greater than 0.");

        RuleFor(v => v.StatusId)
            .GreaterThan(0).WithMessage("Status ID must be greater than 0.");

        // Additional rule to check for the existence of associated entities could be added
        RuleFor(v => v.Status)
            .NotNull().WithMessage("Status must be assigned.");

        RuleFor(v => v.TranType)
            .NotNull().WithMessage("Transaction type must be assigned.");
    }
}
