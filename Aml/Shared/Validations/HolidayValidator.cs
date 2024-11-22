using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class HolidayValidator : AbstractValidator<Holiday>
{
    public HolidayValidator()
    {
        RuleFor(x => x.HolidayId)
            .GreaterThan(0).WithMessage("HolidayId must be greater than 0.");

        RuleFor(x => x.HolidayName)
            .NotEmpty().WithMessage("HolidayName is required.")
            .MaximumLength(50).WithMessage("HolidayName cannot exceed 50 characters.");

        RuleFor(x => x.HolidayDate)
            .NotEmpty().WithMessage("HolidayDate is required.")
            .GreaterThanOrEqualTo(DateTime.Today).WithMessage("HolidayDate cannot be in the past.");

        RuleFor(x => x.MakerId)
            .GreaterThan(0).WithMessage("MakerId must be greater than 0.");

        RuleFor(x => x.CheckerId)
            .GreaterThan(0).WithMessage("CheckerId must be greater than 0.");

        RuleFor(x => x.StatusId)
            .GreaterThan(0).WithMessage("StatusId must be greater than 0.");

        RuleFor(x => x.CheckerDate)
            .NotEmpty().WithMessage("CheckerDate is required.");

        RuleFor(x => x.SysDate)
            .NotNull().WithMessage("SysDate is required.");
    }
}

