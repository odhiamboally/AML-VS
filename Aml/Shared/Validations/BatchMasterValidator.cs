using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class BatchMasterValidator : AbstractValidator<BatchMaster>
{
    public BatchMasterValidator()
    {
        RuleFor(bm => bm.BatchNo)
            .Length(1, 4).WithMessage("Batch No must be between 1 and 4 characters.");

        RuleFor(bm => bm.BatchTypeId)
            .GreaterThan(0).WithMessage("Batch Type must be selected.");

        RuleFor(bm => bm.BranchId)
            .GreaterThan(0).WithMessage("Branch must be selected.");

        RuleFor(bm => bm.UserId)
            .GreaterThan(0).WithMessage("User must be selected.");
    }
}

