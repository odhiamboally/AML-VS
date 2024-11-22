using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class MenuValidator : AbstractValidator<Menu>
{
    public MenuValidator()
    {
        RuleFor(x => x.MenuId)
            .GreaterThan(0).WithMessage("MenuId must be greater than 0.");

        RuleFor(x => x.MenuCode)
            .NotEmpty().WithMessage("MenuCode is required.")
            .MaximumLength(50).WithMessage("MenuCode cannot exceed 50 characters.");

        RuleFor(x => x.MenuName)
            .NotEmpty().WithMessage("MenuName is required.")
            .MaximumLength(50).WithMessage("MenuName cannot exceed 50 characters.");

        RuleFor(x => x.MenuUrl)
            .NotEmpty().WithMessage("MenuUrl is required.");

        RuleFor(x => x.MenuCategoryId)
            .GreaterThan(0).WithMessage("MenuCategoryId must be greater than 0.");

        RuleFor(x => x.MenuLevel)
            .GreaterThanOrEqualTo(0).WithMessage("MenuLevel must be greater than or equal to 0.");

        RuleFor(x => x.StatusId)
            .GreaterThan(0).WithMessage("StatusId must be greater than 0.");
    }
}

