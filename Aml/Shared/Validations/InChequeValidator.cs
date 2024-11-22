using Aml.Shared.Entitties;
using FluentValidation;
namespace Aml.Shared.Validations;

public class InChequeValidator : AbstractValidator<InCheque>
{
    public InChequeValidator()
    {
        RuleFor(i => i.ProcNo)
            .NotEmpty().WithMessage("ProcNo is required")
            .Length(1, 20).WithMessage("ProcNo length must be between 1 and 20 characters");

        RuleFor(i => i.BatchId)
            .NotEmpty().WithMessage("BatchId is required");

        RuleFor(i => i.MLine)
            .NotEmpty().WithMessage("MLine is required");

        RuleFor(i => i.UserId)
            .GreaterThan(0).WithMessage("UserId must be greater than zero");

        RuleFor(i => i.CustAccount)
            .NotEmpty().WithMessage("Customer Account is required")
            .Length(1, 25).WithMessage("Customer Account length must be between 1 and 25 characters");

        RuleFor(i => i.CustName)
            .NotEmpty().WithMessage("Customer Name is required");

        RuleFor(i => i.BankId)
            .GreaterThan(0).WithMessage("BankId must be greater than zero");

        RuleFor(i => i.ClearingCodeId)
            .GreaterThan(0).WithMessage("ClearingCodeId must be greater than zero");

        RuleFor(i => i.CheckDigit)
            .NotEmpty().WithMessage("CheckDigit is required")
            .Length(1, 3).WithMessage("CheckDigit length must be between 1 and 3 characters");

        RuleFor(i => i.Amount)
            .GreaterThan(0).WithMessage("Amount must be greater than zero");

        RuleFor(i => i.CurrencyId)
            .GreaterThan(0).WithMessage("CurrencyId must be greater than zero");

        RuleFor(i => i.SysDate)
            .NotEmpty().WithMessage("SysDate is required");

        RuleFor(i => i.Payee)
            .Length(0, 25).WithMessage("Payee length must be between 0 and 25 characters");

        RuleFor(i => i.PayeeName)
            .Length(0, 255).WithMessage("PayeeName length must be between 0 and 255 characters");
    }
}

