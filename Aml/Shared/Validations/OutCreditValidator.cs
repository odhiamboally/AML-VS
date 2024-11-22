using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class OutCreditValidator : AbstractValidator<OutCredit>
{
    public OutCreditValidator()
    {
        RuleFor(o => o.BatchId)
            .GreaterThan(0)
            .WithMessage("Batch ID must be greater than 0.");

        RuleFor(o => o.ProcNo)
            .NotEmpty()
            .WithMessage("Procedure number is required.")
            .Length(1, 20)
            .WithMessage("Procedure number length must be between 1 and 20 characters.");

        RuleFor(o => o.UserId)
            .GreaterThan(0)
            .WithMessage("User ID must be greater than 0.");

        RuleFor(o => o.CustBranchId)
            .GreaterThan(0)
            .WithMessage("Customer Branch ID must be greater than 0.");

        RuleFor(o => o.CustAccount)
            .NotEmpty()
            .WithMessage("Customer account is required.")
            .Length(1, 25)
            .WithMessage("Customer account length must be between 1 and 25 characters.");

        RuleFor(o => o.CustName)
            .NotEmpty()
            .WithMessage("Customer name is required.");

        RuleFor(o => o.BankId)
            .GreaterThan(0)
            .WithMessage("Bank ID must be greater than 0.");

        RuleFor(o => o.BranchId)
            .GreaterThan(0)
            .WithMessage("Branch ID must be greater than 0.");

        RuleFor(o => o.AccountNo)
            .NotEmpty()
            .WithMessage("Account number is required.")
            .Length(1, 25)
            .WithMessage("Account number length must be between 1 and 25 characters.");

        RuleFor(o => o.BeneficiaryName)
            .NotEmpty()
            .WithMessage("Beneficiary name is required.");

        RuleFor(o => o.OriginatorRef)
            .NotEmpty()
            .WithMessage("Originator reference is required.")
            .Length(1, 35)
            .WithMessage("Originator reference length must be between 1 and 35 characters.");

        RuleFor(o => o.Amount)
            .GreaterThan(0)
            .WithMessage("Amount must be greater than 0.");

        RuleFor(o => o.CurrencyId)
            .GreaterThan(0)
            .WithMessage("Currency ID must be greater than 0.");

        RuleFor(o => o.ClearingCodeId)
            .GreaterThan(0)
            .WithMessage("Clearing code ID must be greater than 0.");
    }
}

