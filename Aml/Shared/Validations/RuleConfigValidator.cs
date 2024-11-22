using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class RuleConfigValidator : AbstractValidator<RuleConfig>
{
    public RuleConfigValidator()
    {
        RuleFor(x => x.RuleCode)
            .NotEmpty().WithMessage("RuleCode is required.")
            .MaximumLength(20).WithMessage("RuleCode cannot exceed 20 characters.");

        RuleFor(x => x.RuleDesc)
            .MaximumLength(250).WithMessage("RuleDesc cannot exceed 250 characters.");

        RuleFor(x => x.RuleName)
            .MaximumLength(250).WithMessage("RuleName cannot exceed 250 characters.");

        RuleFor(x => x.DisplayColumn)
            .MaximumLength(250).WithMessage("DisplayColumn cannot exceed 250 characters.");

        RuleFor(x => x.Condition)
            .MaximumLength(250).WithMessage("Condition cannot exceed 250 characters.");

        RuleFor(x => x.RuleSource)
            .MaximumLength(50).WithMessage("RuleSource cannot exceed 50 characters.");

        RuleFor(x => x.Functional)
            .NotNull().WithMessage("Functional field cannot be null.");

        RuleFor(x => x.Entity)
            .MaximumLength(50).WithMessage("Entity cannot exceed 50 characters.");

        RuleFor(x => x.CategoryId)
            .GreaterThan(0).When(x => x.CategoryId.HasValue).WithMessage("CategoryId must be greater than 0.");

        RuleFor(x => x.ChannelId)
            .GreaterThan(0).When(x => x.ChannelId.HasValue).WithMessage("ChannelId must be greater than 0.");

        RuleFor(x => x.CurrencyId)
            .GreaterThan(0).When(x => x.CurrencyId.HasValue).WithMessage("CurrencyId must be greater than 0.");
    }
}

