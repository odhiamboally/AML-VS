using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class AchFileStatusValidator : AbstractValidator<AchFileStatus>
{
    public AchFileStatusValidator()
    {
        RuleFor(afs => afs.AchFileName)
            .NotEmpty().WithMessage("ACH File Name is required.");

        RuleFor(afs => afs.AchCodeId)
            .Length(1, 10).WithMessage("ACH Code ID must be between 1 and 10 characters.")
            .NotEmpty().WithMessage("ACH Code ID is required.");

        RuleFor(afs => afs.CreateTime)
            .NotNull().WithMessage("Create Time is required.");

        RuleFor(afs => afs.TranTypeId)
            .GreaterThan(0).WithMessage("Transaction Type must be selected.");
    }
}

