using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class TranTypeValidator : AbstractValidator<TranType>
{
    public TranTypeValidator()
    {
        RuleFor(t => t.TranTypeCode)
            .NotEmpty().WithMessage("Transaction type code is required.")
            .Length(5).WithMessage("Transaction type code must be exactly 5 characters.");

        RuleFor(t => t.TranTypeDesc)
            .NotEmpty().WithMessage("Transaction type description is required.");
    }
}

