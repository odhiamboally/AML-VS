using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class PasswordListValidator : AbstractValidator<PasswordList>
{
    public PasswordListValidator()
    {
        RuleFor(x => x.PasswordListId)
            .GreaterThan(0).WithMessage("PasswordListId must be greater than 0.");

        RuleFor(x => x.UserId)
            .GreaterThan(0).WithMessage("UserId must be greater than 0.");

        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required.")
            .MaximumLength(100).WithMessage("Password cannot exceed 100 characters.");

        RuleFor(x => x.ChangeDate)
            .NotEmpty().WithMessage("ChangeDate is required.");
    }
}

