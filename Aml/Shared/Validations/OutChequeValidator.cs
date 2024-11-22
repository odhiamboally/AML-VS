using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class OutChequeValidator : AbstractValidator<OutCheque>
{
    public OutChequeValidator()
    {
        RuleFor(o => o.ProcNo)
            .NotEmpty()
            .WithMessage("ProcNo is required.")
            .Length(1, 20)
            .WithMessage("ProcNo must be between 1 and 20 characters.");

        RuleFor(o => o.MLine)
            .NotEmpty()
            .WithMessage("MLine is required.");

        RuleFor(o => o.CustAccount)
            .NotEmpty()
            .WithMessage("Customer account is required.")
            .Length(1, 25)
            .WithMessage("Customer account must be between 1 and 25 characters.");

        RuleFor(o => o.CustName)
            .NotEmpty()
            .WithMessage("Customer name is required.");

        RuleFor(o => o.Amount)
            .GreaterThan(0)
            .WithMessage("Amount must be greater than 0.");

        RuleFor(o => o.CheckDigit)
            .NotEmpty()
            .WithMessage("Check digit is required.")
            .Length(3)
            .WithMessage("Check digit must be exactly 3 characters.");

        RuleFor(o => o.FileId)
            .NotEmpty()
            .WithMessage("FileId is required.");
    }
}

