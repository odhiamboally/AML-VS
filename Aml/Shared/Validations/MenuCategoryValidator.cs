using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class MenuCategoryValidator : AbstractValidator<MenuCategory>
{
    public MenuCategoryValidator()
    {
        RuleFor(x => x.MenuCategoryId)
            .GreaterThan(0).WithMessage("MenuCategoryId must be greater than 0.");

        RuleFor(x => x.MenuCategoryName)
            .NotEmpty().WithMessage("MenuCategoryName is required.")
            .MaximumLength(25).WithMessage("MenuCategoryName cannot exceed 25 characters.");
    }
}

