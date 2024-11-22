using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class LocationTypeValidator : AbstractValidator<LocationType>
{
    public LocationTypeValidator()
    {
        RuleFor(x => x.LocationTypeId)
            .GreaterThan(0).WithMessage("LocationTypeId must be greater than 0.");

        RuleFor(x => x.LocationTypeCode)
            .NotEmpty().WithMessage("LocationTypeCode is required.")
            .MaximumLength(5).WithMessage("LocationTypeCode cannot exceed 5 characters.");

        RuleFor(x => x.LocationTypeDesc)
            .NotEmpty().WithMessage("LocationTypeDesc is required.")
            .MaximumLength(255).WithMessage("LocationTypeDesc cannot exceed 255 characters.");

        RuleFor(x => x.StatusId)
            .GreaterThan(0).WithMessage("StatusId must be greater than 0.");
    }
}

