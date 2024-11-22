using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class UploadParamValidator : AbstractValidator<UploadParam>
{
    public UploadParamValidator()
    {
        RuleFor(up => up.OutChequeLedger)
            .NotEmpty()
            .MaximumLength(25);

        RuleFor(up => up.OutChequeCode)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(up => up.InChequeLedger)
            .NotEmpty()
            .MaximumLength(25);

        RuleFor(up => up.InChequeCode)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(up => up.OutRtgsLedger)
            .NotEmpty()
            .MaximumLength(25);

        RuleFor(up => up.OutRtgsCode)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(up => up.InRtgsLedger)
            .NotEmpty()
            .MaximumLength(25);

        RuleFor(up => up.InRtgsCode)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(up => up.OutCreditLedger)
            .NotEmpty()
            .MaximumLength(25);

        RuleFor(up => up.OutCreditCode)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(up => up.StatusId)
            .GreaterThan(0)
            .WithMessage("StatusId must be a positive integer.");
    }
}

