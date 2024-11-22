using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class SlipValidator : AbstractValidator<Slip>
{
    public SlipValidator()
    {
        RuleFor(s => s.SlipNo)
            .NotEmpty().WithMessage("Slip number is required.")
            .Length(1, 4).WithMessage("Slip number must be between 1 and 4 characters.");

        RuleFor(s => s.BatchId)
            .NotEmpty().WithMessage("Batch ID is required.");

        RuleFor(s => s.CustBranchId)
            .NotEmpty().WithMessage("Customer branch ID is required.");

        RuleFor(s => s.CustAccount)
            .NotEmpty().WithMessage("Customer account is required.")
            .Length(1, 25).WithMessage("Customer account must be between 1 and 25 characters.");

        RuleFor(s => s.ItemCount)
            .GreaterThanOrEqualTo(0).WithMessage("Item count must be a non-negative number.");

        RuleFor(s => s.ItemSum)
            .GreaterThanOrEqualTo(0).WithMessage("Item sum must be a non-negative number.");

        RuleFor(s => s.Remarks)
            .MaximumLength(500).WithMessage("Remarks must not exceed 500 characters.");

        RuleFor(s => s.BackupDate)
            .LessThanOrEqualTo(DateTime.Now).WithMessage("Backup date cannot be in the future.");

        RuleFor(s => s.SystDate)
            .NotNull().WithMessage("System date is required.");
    }
}

