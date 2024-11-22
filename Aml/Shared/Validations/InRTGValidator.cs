using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class InRTGValidator : AbstractValidator<InRTG>
{
    public InRTGValidator()
    {
        RuleFor(i => i.ProcNo)
            .NotEmpty()
            .WithMessage("ProcNo is required")
            .Length(1, 20)
            .WithMessage("ProcNo must be between 1 and 20 characters");

        RuleFor(i => i.CustAccount)
            .NotEmpty()
            .WithMessage("CustAccount is required")
            .Length(1, 25)
            .WithMessage("CustAccount must be between 1 and 25 characters");

        RuleFor(i => i.CustName)
            .NotEmpty()
            .WithMessage("CustName is required");

        RuleFor(i => i.AccountNo)
            .NotEmpty()
            .WithMessage("AccountNo is required")
            .Length(1, 25)
            .WithMessage("AccountNo must be between 1 and 25 characters");

        RuleFor(i => i.BeneficiaryName)
            .NotEmpty()
            .WithMessage("BeneficiaryName is required");

        RuleFor(i => i.OriginatorRef)
            .NotEmpty()
            .WithMessage("OriginatorRef is required");

        RuleFor(i => i.Amount)
            .GreaterThan(0)
            .WithMessage("Amount must be greater than zero");

        RuleFor(i => i.Captured)
            .NotNull()
            .WithMessage("Captured status is required");

        RuleFor(i => i.Authorized)
            .NotNull()
            .WithMessage("Authorization status is required");

        RuleFor(i => i.Uploaded)
            .NotNull()
            .WithMessage("Uploaded status is required");

        RuleFor(i => i.Upload)
            .NotNull()
            .WithMessage("Upload status is required");

        RuleFor(i => i.Returned)
            .NotNull()
            .WithMessage("Returned status is required");

        RuleFor(i => i.BackupDate)
            .NotNull()
            .WithMessage("BackupDate is required");
    }
}

