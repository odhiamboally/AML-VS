using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class CpoReferenceValidator : AbstractValidator<CpoReference>
{
    public CpoReferenceValidator()
    {
        RuleFor(x => x.DdMicrNo)
            .NotEmpty().WithMessage("DDMICRNO is required.")
            .MaximumLength(20).WithMessage("DDMICRNO cannot exceed 20 characters.");

        RuleFor(x => x.AccountNo)
            .NotEmpty().WithMessage("AccountNo is required.")
            .MaximumLength(25).WithMessage("AccountNo cannot exceed 25 characters.");

        RuleFor(x => x.Amount)
            .GreaterThan(0).WithMessage("Amount must be greater than 0.");

        RuleFor(x => x.LcyAmount)
            .GreaterThan(0).WithMessage("LCYAmount must be greater than 0.");

        RuleFor(x => x.CurrencyId)
            .GreaterThan(0).WithMessage("CurrencyId must be greater than 0.");

        RuleFor(x => x.InstrumentNo)
            .MaximumLength(50).WithMessage("InstrumentNo cannot exceed 50 characters.");

        RuleFor(x => x.Beneficiary)
            .MaximumLength(100).WithMessage("Beneficiary cannot exceed 100 characters.");

        RuleFor(x => x.Narrative)
            .MaximumLength(255).WithMessage("Narrative cannot exceed 255 characters.");
    }
}

