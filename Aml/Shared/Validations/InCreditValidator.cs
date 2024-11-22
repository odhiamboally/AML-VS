using Aml.Channels.Clearing.Entities;
using FluentValidation;

namespace Aml.Shared.Validations;

using FluentValidation;
using System;

public class InCreditValidator : AbstractValidator<InCredit>
{
    public InCreditValidator()
    {
        RuleFor(ic => ic.InCreditId)
            .GreaterThan(0).WithMessage("INCREDITID must be greater than 0.");

        RuleFor(ic => ic.BatchId)
            .GreaterThan(0).WithMessage("BATCHID must be greater than 0.");

        RuleFor(ic => ic.ProcNo)
            .NotEmpty().WithMessage("PROCNO is required.")
            .Length(1, 20).WithMessage("PROCNO must be between 1 and 20 characters.");

        RuleFor(ic => ic.UserId)
            .GreaterThan(0).WithMessage("USERID must be greater than 0.");

        RuleFor(ic => ic.CustBranchId)
            .GreaterThan(0).WithMessage("CUSTBRANCHID must be greater than 0.");

        RuleFor(ic => ic.CustAccount)
            .NotEmpty().WithMessage("CUSTACCOUNT is required.")
            .Length(1, 25).WithMessage("CUSTACCOUNT must be between 1 and 25 characters.");

        RuleFor(ic => ic.CustName)
            .NotEmpty().WithMessage("CUSTNAME is required.");

        RuleFor(ic => ic.BankId)
            .GreaterThan(0).WithMessage("BANKID must be greater than 0.");

        RuleFor(ic => ic.BranchId)
            .GreaterThan(0).WithMessage("BRANCHID must be greater than 0.");

        RuleFor(ic => ic.AccountNo)
            .NotEmpty().WithMessage("ACCOUNTNO is required.")
            .Length(1, 25).WithMessage("ACCOUNTNO must be between 1 and 25 characters.");

        RuleFor(ic => ic.BeneficiaryName)
            .NotEmpty().WithMessage("BENEFICIARYNAME is required.");

        RuleFor(ic => ic.OriginatorRef)
            .NotEmpty().WithMessage("ORIGINATORREF is required.")
            .Length(1, 35).WithMessage("ORIGINATORREF must be between 1 and 35 characters.");

        RuleFor(ic => ic.VoucherId)
            .GreaterThan(0).WithMessage("VOUCHERID must be greater than 0.");

        RuleFor(ic => ic.Amount)
            .GreaterThan(0).WithMessage("AMOUNT must be greater than 0.");

        RuleFor(ic => ic.CurrencyId)
            .GreaterThan(0).WithMessage("CURRENCYID must be greater than 0.");

        RuleFor(ic => ic.ClearingCodeId)
            .GreaterThan(0).WithMessage("CLEARINGCODEID must be greater than 0.");

        RuleFor(ic => ic.Remarks)
            .MaximumLength(500).WithMessage("REMARKS must be less than or equal to 500 characters.");

        RuleFor(ic => ic.Captured)
            .NotNull().WithMessage("CAPTURED cannot be null.");

        RuleFor(ic => ic.Authorized)
            .NotNull().WithMessage("AUTHORIZED cannot be null.");

        RuleFor(ic => ic.Uploaded)
            .NotNull().WithMessage("UPLOADED cannot be null.");

        RuleFor(ic => ic.Upload)
            .NotNull().WithMessage("UPLOAD cannot be null.");

        RuleFor(ic => ic.Returned)
            .NotNull().WithMessage("RETURNED cannot be null.");

        RuleFor(ic => ic.ReturnReasonId)
            .GreaterThan(0).WithMessage("RETURNREASONID must be greater than 0.");

        RuleFor(ic => ic.BackupDate)
            .LessThanOrEqualTo(DateTime.Now).WithMessage("BACKUPDATE cannot be in the future.");

        RuleFor(ic => ic.SystDate)
            .NotEmpty().WithMessage("SYSTDATE is required.")
            .WithMessage("SYSTDATE must be exactly 8 bytes.");

        RuleFor(ic => ic.FileId)
            .MaximumLength(50).WithMessage("FILEID must be less than or equal to 50 characters.");

        RuleFor(ic => ic.SourceRef)
            .NotEmpty().WithMessage("SOURCE_REF is required.")
            .Length(1, 20).WithMessage("SOURCE_REF must be between 1 and 20 characters.");

        RuleFor(ic => ic.FlagedClearingCodeId)
            .GreaterThan(0).WithMessage("FLAGEDCLEARINGCODEID must be greater than 0.");

        RuleFor(ic => ic.ValueDate)
            .LessThanOrEqualTo(DateTime.Now).WithMessage("VALUEDATE cannot be in the future.");

        RuleFor(ic => ic.PmtTpInf)
            .Length(1).WithMessage("PmtTpInf must be 1 character.");

        RuleFor(ic => ic.PmtTpInfCode)
            .Length(2).WithMessage("PmtTpInfCode must be 2 characters.");

        RuleFor(ic => ic.DrTwnNm)
            .MaximumLength(50).WithMessage("DrTwnNm must be less than or equal to 50 characters.");

        RuleFor(ic => ic.DrAdrLine)
            .MaximumLength(50).WithMessage("DrAdrLine must be less than or equal to 50 characters.");

        RuleFor(ic => ic.CrTwnNm)
            .MaximumLength(50).WithMessage("CrTwnNm must be less than or equal to 50 characters.");

        RuleFor(ic => ic.CrAdrLine)
            .MaximumLength(50).WithMessage("CrAdrLine must be less than or equal to 50 characters.");

        RuleFor(ic => ic.InstrId)
            .MaximumLength(50).WithMessage("InstrId must be less than or equal to 50 characters.");

        RuleFor(ic => ic.EndToEndId)
            .MaximumLength(50).WithMessage("EndToEndId must be less than or equal to 50 characters.");

        RuleFor(ic => ic.TxId)
            .MaximumLength(50).WithMessage("TxId must be less than or equal to 50 characters.");

        RuleFor(ic => ic.MsgId)
            .MaximumLength(50).WithMessage("MSGID must be less than or equal to 50 characters.");

        RuleFor(ic => ic.CustAccountOrg)
            .MaximumLength(25).WithMessage("CUSTACCOUNT_ORG must be less than or equal to 25 characters.");

        RuleFor(ic => ic.CustNameOrg)
            .MaximumLength(50).WithMessage("CUSTNAME_ORG must be less than or equal to 50 characters.");

        RuleFor(ic => ic.CbsPosted)
            .GreaterThanOrEqualTo(0).WithMessage("CBSPOSTED must be greater than or equal to 0.");

        RuleFor(ic => ic.UploadAttemptRef)
            .MaximumLength(50).WithMessage("UPLOAD_ATTEMPT_REF must be less than or equal to 50 characters.");

        RuleFor(ic => ic.AmlStatus)
            .MaximumLength(10).WithMessage("AMLSTATUS must be less than or equal to 10 characters.");
    }
}
