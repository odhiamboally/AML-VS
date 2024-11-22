using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class RegionValidator : AbstractValidator<Region>
{
    public RegionValidator()
    {
        RuleFor(r => r.RegionCode)
            .NotEmpty().WithMessage("Region code is required.")
            .Length(5).WithMessage("Region code must be exactly 5 characters.");

        RuleFor(r => r.RegionName)
            .NotEmpty().WithMessage("Region name is required.");
    }
}

