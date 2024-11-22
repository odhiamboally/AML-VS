using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class AccountTempValidator : AbstractValidator<AccountTemp>
{
    public AccountTempValidator()
    {
        RuleFor(x => x.CustomerNo)
            .NotEmpty().WithMessage("CustomerNo is required.")
            .MaximumLength(25).WithMessage("CustomerNo cannot exceed 25 characters.");

        RuleFor(x => x.AccountNo)
            .NotEmpty().WithMessage("AccountNo is required.")
            .MaximumLength(25).WithMessage("AccountNo cannot exceed 25 characters.");

        RuleFor(x => x.AccountName)
            .NotEmpty().WithMessage("AccountName is required.");

        RuleFor(x => x.CurrencyId)
            .GreaterThan(0).WithMessage("CurrencyId must be greater than 0.");

        RuleFor(x => x.BranchId)
            .GreaterThan(0).WithMessage("BranchId must be greater than 0.");

        RuleFor(x => x.StatusId)
            .GreaterThan(0).WithMessage("StatusId must be greater than 0.");

        RuleFor(x => x.UploadMethodId)
            .GreaterThan(0).WithMessage("UploadMethodId must be greater than 0.");

        RuleFor(x => x.NewAccount)
            .MaximumLength(15).WithMessage("NewAccount cannot exceed 15 characters.");

        RuleFor(x => x.AccountClass)
            .MaximumLength(50).WithMessage("AccountClass cannot exceed 50 characters.");

        RuleFor(x => x.ReactivationDate)
            .LessThanOrEqualTo(DateTime.Today).WithMessage("ReactivationDate cannot be in the future.");

        RuleFor(x => x.CreationDate)
            .MaximumLength(50).WithMessage("CreationDate cannot exceed 50 characters.");

        RuleFor(x => x.ExemptAutoDelete)
            .NotNull().WithMessage("ExemptAutoDelete cannot be null.");
    }
}

