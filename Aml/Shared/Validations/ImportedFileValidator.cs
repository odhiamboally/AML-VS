namespace Aml.Shared.Validations;

using Aml.Shared.Entitties;
using FluentValidation;

public class ImportedFileValidator : AbstractValidator<ImportedFile>
{
    public ImportedFileValidator()
    {
        RuleFor(i => i.ImportedFileName)
            .NotEmpty().WithMessage("Imported File Name is required.")
            .Length(1, 100).WithMessage("Imported File Name must be between 1 and 100 characters.");

        RuleFor(i => i.FullPath)
            .NotEmpty().WithMessage("Full Path is required.");

        RuleFor(i => i.FileSize)
            .GreaterThan(0).WithMessage("File Size must be greater than 0.");

        RuleFor(i => i.ImportDate)
            .NotEmpty().WithMessage("Import Date is required.");

        RuleFor(i => i.UserId)
            .GreaterThan(0).WithMessage("User ID must be greater than 0.");

        RuleFor(i => i.NoOfRecords)
            .GreaterThanOrEqualTo(0).WithMessage("Number of Records must be greater than or equal to 0.");

        RuleFor(i => i.TotalAmount)
            .GreaterThanOrEqualTo(0).WithMessage("Total Amount must be greater than or equal to 0.");

        RuleFor(i => i.NoOfRejects)
            .GreaterThanOrEqualTo(0).WithMessage("Number of Rejects must be greater than or equal to 0.");

        RuleFor(i => i.RejectAmount)
            .GreaterThanOrEqualTo(0).WithMessage("Reject Amount must be greater than or equal to 0.");
    }
}

