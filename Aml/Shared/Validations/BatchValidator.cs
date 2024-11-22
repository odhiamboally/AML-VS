using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class BatchValidator : AbstractValidator<Batch>
{
    public BatchValidator()
    {
        RuleFor(b => b.BatchNo)
            .NotEmpty()
            .WithMessage("Batch number is required.")
            .Length(1, 4)
            .WithMessage("Batch number length must be between 1 and 4 characters.");

        RuleFor(b => b.BranchId)
            .GreaterThan(0)
            .WithMessage("Branch ID must be greater than 0.");

        RuleFor(b => b.CurrencyId)
            .GreaterThan(0)
            .WithMessage("Currency ID must be greater than 0.");

        RuleFor(b => b.BatchTypeId)
            .GreaterThan(0)
            .WithMessage("Batch type ID must be greater than 0.");

        RuleFor(b => b.ClearingSessionId)
            .GreaterThan(0)
            .WithMessage("Clearing session ID must be greater than 0.");

        RuleFor(b => b.UserId)
            .GreaterThan(0)
            .WithMessage("User ID must be greater than 0.");

        RuleFor(b => b.Day2)
            .NotNull()
            .WithMessage("Day2 flag is required.");

        RuleFor(b => b.Captured)
            .NotNull()
            .WithMessage("Captured flag is required.");

        RuleFor(b => b.Verified)
            .NotNull()
            .WithMessage("Verified flag is required.");

        RuleFor(b => b.Authorized)
            .NotNull()
            .WithMessage("Authorized flag is required.");

        RuleFor(b => b.Uploaded)
            .NotNull()
            .WithMessage("Uploaded flag is required.");

        RuleFor(b => b.Commissioned)
            .NotNull()
            .WithMessage("Commissioned flag is required.");

        RuleFor(b => b.SysDate)
            .NotNull()
            .WithMessage("System date is required.");
    }
}

