using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class CategoryValidator : AbstractValidator<Category>
{
    public CategoryValidator()
    {
        RuleFor(x => x.CategoryName)
            .MaximumLength(50).WithMessage("CategoryName cannot exceed 50 characters.");

        RuleFor(x => x.CategoryValue)
            .MaximumLength(50).WithMessage("CategoryValue cannot exceed 50 characters.");

        RuleFor(x => x.CategoryDesc)
            .MaximumLength(100).WithMessage("CategoryDesc cannot exceed 100 characters.");
    }
}

