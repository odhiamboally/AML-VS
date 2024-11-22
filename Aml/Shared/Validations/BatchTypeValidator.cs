using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class BatchTypeValidator : AbstractValidator<BatchType>
{
    public BatchTypeValidator()
    {
        RuleFor(b => b.BatchTypeCode)
            .Length(1, 3).WithMessage("Batch Type Code must be between 1 and 3 characters.");

        RuleFor(b => b.BatchTypeDesc)
            .MaximumLength(500).WithMessage("Batch Type Description cannot exceed 500 characters.");
    }
}

