using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class UnusedChequeValidator : AbstractValidator<UnusedCheque>
{
    public UnusedChequeValidator()
    {
        RuleFor(uc => uc.AccountNo)
            .NotEmpty()
            .MaximumLength(25);

        RuleFor(uc => uc.BranchId)
            .GreaterThan(0)
            .WithMessage("BranchId must be a positive integer.");

        RuleFor(uc => uc.ChequeNo)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(uc => uc.ChequeBookNo)
            .MaximumLength(20);

        RuleFor(uc => uc.Used)
            .InclusiveBetween(0, 1)
            .WithMessage("Used must be either 0 (not used) or 1 (used).");
    }
}

