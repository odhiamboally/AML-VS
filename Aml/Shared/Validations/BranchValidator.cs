using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class BranchValidator : AbstractValidator<Branch>
{
    public BranchValidator()
    {
        RuleFor(b => b.BankId)
            .GreaterThan(0).WithMessage("BankId must be greater than 0.");

        RuleFor(b => b.BranchCode)
            .NotEmpty().WithMessage("BranchCode is required.")
            .Length(1, 5).WithMessage("BranchCode must be between 1 and 5 characters.");

        RuleFor(b => b.BranchName)
            .NotEmpty().WithMessage("BranchName is required.")
            .MaximumLength(100).WithMessage("BranchName must not exceed 100 characters.");

        RuleFor(b => b.LocationTypeId)
            .GreaterThan(0).WithMessage("LocationTypeId must be greater than 0.");

        RuleFor(b => b.RegionId)
            .GreaterThan(0).WithMessage("RegionId must be greater than 0.");

        RuleFor(b => b.UploadCode)
            .NotEmpty().WithMessage("UploadCode is required.")
            .MaximumLength(10).WithMessage("UploadCode must not exceed 10 characters.");

        RuleFor(b => b.StatusId)
            .GreaterThan(0).WithMessage("StatusId must be greater than 0.");
    }
}
