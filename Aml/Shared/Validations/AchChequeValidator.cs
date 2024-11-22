using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class AchChequeValidator : AbstractValidator<AchCheque>
{
    public AchChequeValidator()
    {
        RuleFor(a => a.ProcNo)
            .NotEmpty().WithMessage("ProcNo is required")
            .Length(1, 20).WithMessage("ProcNo must be between 1 and 20 characters");

        RuleFor(a => a.MLine)
            .NotEmpty().WithMessage("MLine is required");

        RuleFor(a => a.CustAccount)
            .NotEmpty().WithMessage("CustAccount is required")
            .Length(1, 25).WithMessage("CustAccount must be between 1 and 25 characters");

        RuleFor(a => a.CustName)
            .NotEmpty().WithMessage("CustName is required");

        RuleFor(a => a.AccountNo)
            .NotEmpty().WithMessage("AccountNo is required")
            .Length(1, 25).WithMessage("AccountNo must be between 1 and 25 characters");

        RuleFor(a => a.AccountName)
            .NotEmpty().WithMessage("AccountName is required");

        RuleFor(a => a.ChequeNo)
            .NotEmpty().WithMessage("ChequeNo is required")
            .Length(1, 15).WithMessage("ChequeNo must be between 1 and 15 characters");

        RuleFor(a => a.Amount)
            .GreaterThan(0).WithMessage("Amount must be greater than 0");

        RuleFor(a => a.CheckDigit)
            .NotEmpty().WithMessage("CheckDigit is required")
            .Length(3).WithMessage("CheckDigit must be exactly 3 characters");

        RuleFor(a => a.ValueDate)
            .NotEmpty().WithMessage("ValueDate is required");

        RuleFor(a => a.Remarks)
            .MaximumLength(255).WithMessage("Remarks cannot be longer than 255 characters");

        RuleFor(a => a.FileName)
            .MaximumLength(255).WithMessage("FileName cannot be longer than 255 characters");

        RuleFor(a => a.TransRef)
            .MaximumLength(255).WithMessage("TransRef cannot be longer than 255 characters");

        RuleFor(a => a.FileId)
            .MaximumLength(100).WithMessage("FileId cannot be longer than 100 characters");

        RuleFor(a => a.SysDate)
            .NotNull().WithMessage("SysDate is required");

        RuleFor(a => a.InstructionId)
            .MaximumLength(50).WithMessage("InstructionId cannot be longer than 50 characters");

        RuleFor(a => a.DrTwnNm)
            .MaximumLength(50).WithMessage("DrTwnNm cannot be longer than 50 characters");

        RuleFor(a => a.DrAdrLine)
            .MaximumLength(50).WithMessage("DrAdrLine cannot be longer than 50 characters");

        RuleFor(a => a.CrTwnNm)
            .MaximumLength(50).WithMessage("CrTwnNm cannot be longer than 50 characters");

        RuleFor(a => a.CrAdrLine)
            .MaximumLength(50).WithMessage("CrAdrLine cannot be longer than 50 characters");

        RuleFor(a => a.PmtTpInfCode)
            .MaximumLength(2).WithMessage("PmtTpInfCode cannot be longer than 2 characters");

        RuleFor(a => a.PmtTpInf)
            .MaximumLength(1).WithMessage("PmtTpInf cannot be longer than 1 character");

        RuleFor(a => a.InstrId)
            .MaximumLength(50).WithMessage("InstrId cannot be longer than 50 characters");

        RuleFor(a => a.EndToEndId)
            .MaximumLength(50).WithMessage("EndToEndId cannot be longer than 50 characters");

        RuleFor(a => a.TxId)
            .MaximumLength(50).WithMessage("TxId cannot be longer than 50 characters");

        RuleFor(a => a.MsgId)
            .MaximumLength(50).WithMessage("MsgId cannot be longer than 50 characters");
    }
}
