using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class UploadBatchValidator : AbstractValidator<UploadBatch>
{
    public UploadBatchValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0).WithMessage("Id must be greater than 0.");

        RuleFor(x => x.Batch)
            .NotEmpty().WithMessage("Batch is required.")
            .MaximumLength(10).WithMessage("Batch cannot exceed 10 characters.");

        RuleFor(x => x.SessionId)
            .GreaterThan(0).WithMessage("SessionId must be greater than 0.");

        RuleFor(x => x.CurrencyId)
            .GreaterThan(0).WithMessage("CurrencyId must be greater than 0.");

        RuleFor(x => x.Description)
            .MaximumLength(50).WithMessage("Description cannot exceed 50 characters.");
    }
}

