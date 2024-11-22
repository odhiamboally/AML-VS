using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class BatchSeqValidator : AbstractValidator<BatchSeq>
{
    public BatchSeqValidator()
    {
        RuleFor(bs => bs.BatchSeqId)
            .GreaterThan(0).WithMessage("Batch Sequence ID must be greater than 0.");

        RuleFor(bs => bs.BranchId)
            .GreaterThan(0).WithMessage("Branch ID must be greater than 0.");

        RuleFor(bs => bs.BatchSeed)
            .GreaterThanOrEqualTo(0).WithMessage("Batch Seed must be zero or greater.");

        RuleFor(bs => bs.CurrentBatch)
            .GreaterThanOrEqualTo(0).WithMessage("Current Batch must be zero or greater.");
    }
}

