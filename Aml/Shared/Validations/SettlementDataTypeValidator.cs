using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class SettlementDataTypeValidator : AbstractValidator<SettlementDataType>
{
    public SettlementDataTypeValidator()
    {
        RuleFor(sdt => sdt.TypeDescription)
            .NotEmpty().WithMessage("Type Description is required.")
            .Length(1, 50).WithMessage("Type Description must be between 1 and 50 characters.");

        RuleFor(sdt => sdt.TypeCode)
            .NotEmpty().WithMessage("Type Code is required.")
            .Length(2).WithMessage("Type Code must be exactly 2 characters.");

        RuleFor(sdt => sdt.SettlementDataTypeId)
            .GreaterThan(0).WithMessage("Settlement Data Type ID must be greater than 0.");
    }
}

