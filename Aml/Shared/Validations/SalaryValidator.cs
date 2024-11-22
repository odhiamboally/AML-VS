using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class SalaryValidator : AbstractValidator<Salary>
{
    public SalaryValidator()
    {
        RuleFor(s => s.EmpName)
            .NotEmpty().WithMessage("Employee name is required.");

        RuleFor(s => s.EmpAccNo)
            .NotEmpty().WithMessage("Employee account number is required.");

        RuleFor(s => s.Amount)
            .GreaterThan(0).WithMessage("Salary amount must be greater than zero.");

        RuleFor(s => s.BankId)
            .NotEmpty().WithMessage("Bank ID is required.");

        RuleFor(s => s.BranchId)
            .NotEmpty().WithMessage("Branch ID is required.");

        RuleFor(s => s.SalaryDate)
            .NotEmpty().WithMessage("Salary date is required.");

        RuleFor(s => s.RegionId)
            .NotEmpty().WithMessage("Region ID is required.");

        RuleFor(s => s.CurrencyId)
            .NotEmpty().WithMessage("Currency ID is required.");

        RuleFor(s => s.ProcNo)
            .NotEmpty().WithMessage("Process number is required.")
            .Length(1, 20).WithMessage("Process number must be between 1 and 20 characters.");

        RuleFor(s => s.SysDate)
            .NotEmpty().WithMessage("System date is required.");

        RuleFor(s => s.ClientName)
            .MaximumLength(100).WithMessage("Client name must be at most 100 characters.");

        RuleFor(s => s.ClientAccNo)
            .MaximumLength(50).WithMessage("Client account number must be at most 50 characters.");

        RuleFor(s => s.FileName)
            .MaximumLength(255).WithMessage("File name must be at most 255 characters.");

        RuleFor(s => s.ImportedFileId)
            .NotEmpty().WithMessage("Imported file ID is required.");

        RuleFor(s => s.BatchId)
            .NotEmpty().WithMessage("Batch ID is required.");
    }
}

