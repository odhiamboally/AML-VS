using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class AccessRightValidator : AbstractValidator<AccessRight>
{
    public AccessRightValidator()
    {
        RuleFor(x => x.AccessRightId)
            .GreaterThan(0).WithMessage("AccessRightId must be greater than 0.");

        RuleFor(x => x.ProfileId)
            .GreaterThan(0).WithMessage("ProfileId must be greater than 0.");

        RuleFor(x => x.MenuId)
            .GreaterThan(0).WithMessage("MenuId must be greater than 0.");

        RuleFor(x => x.StatusId)
            .GreaterThan(0).WithMessage("StatusId must be greater than 0.");

        RuleFor(x => x.UserId)
            .GreaterThan(0).WithMessage("UserId must be greater than 0.");
    }
}

