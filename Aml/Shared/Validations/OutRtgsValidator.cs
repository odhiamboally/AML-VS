using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class OutRtgsValidator : AbstractValidator<OutRtgs>
{
    public OutRtgsValidator()
    {
        RuleFor(rtgs => rtgs.ProcNo)
            .NotEmpty()
            .Length(1, 20);

        RuleFor(rtgs => rtgs.CustAccount)
            .NotEmpty()
            .Length(1, 25);

        RuleFor(rtgs => rtgs.CustName)
            .NotEmpty();

        RuleFor(rtgs => rtgs.AccountNo)
            .NotEmpty()
            .Length(1, 25);

        RuleFor(rtgs => rtgs.BeneficiaryName)
            .NotEmpty();

        RuleFor(rtgs => rtgs.OriginatorRef)
            .NotEmpty()
            .Length(1, 35);

        RuleFor(rtgs => rtgs.Amount)
            .GreaterThan(0);

        RuleFor(rtgs => rtgs.FileId)
            .NotEmpty();

        RuleFor(rtgs => rtgs.BackupDate)
            .GreaterThanOrEqualTo(DateTime.UtcNow).When(rtgs => rtgs.BackupDate.HasValue);
    }
}

