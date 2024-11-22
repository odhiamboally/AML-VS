using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class StoppedChequeValidator : AbstractValidator<StoppedCheque>
{
    public StoppedChequeValidator()
    {
        RuleFor(sc => sc.StoppedChequeNo)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(sc => sc.AccountNo)
            .NotEmpty()
            .MaximumLength(25);

        RuleFor(sc => sc.StartAt)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(sc => sc.EndAt)
            .NotEmpty()
            .MaximumLength(20);

        RuleFor(sc => sc.CodeLine)
            .NotEmpty();

        RuleFor(sc => sc.BranchId)
            .GreaterThan(0);

        RuleFor(sc => sc.Amount)
            .GreaterThan(0)
            .WithMessage("Amount must be greater than zero.");
    }
}

