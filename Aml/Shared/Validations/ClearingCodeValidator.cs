using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class ClearingCodeValidator : AbstractValidator<ClearingCode>
{
    public ClearingCodeValidator()
    {
        RuleFor(x => x.ClearingCodeName)
            .NotEmpty().WithMessage("Clearing code name is required.")
            .Length(1, 5).WithMessage("Clearing code name must be between 1 and 5 characters.");

        RuleFor(x => x.ClearingCodeDesc)
            .NotEmpty().WithMessage("Clearing code description is required.");

        RuleFor(x => x.TranTypeId)
            .GreaterThan(0).WithMessage("Transaction type ID must be a valid positive number.");

        RuleFor(x => x.StatusId)
            .GreaterThan(0).WithMessage("Status ID must be a valid positive number.");

        RuleFor(x => x.InUnpayChargeUsd)
            .GreaterThanOrEqualTo(0).WithMessage("In-unpay charge USD must be greater than or equal to 0.");

        RuleFor(x => x.OutUnpayChargeUsd)
            .GreaterThanOrEqualTo(0).WithMessage("Out-unpay charge USD must be greater than or equal to 0.");

        RuleFor(x => x.InUnpayCharge)
            .GreaterThanOrEqualTo(0).WithMessage("In-unpay charge must be greater than or equal to 0.");

        RuleFor(x => x.OutUnpayCharge)
            .GreaterThanOrEqualTo(0).WithMessage("Out-unpay charge must be greater than or equal to 0.");

        RuleFor(x => x.InUnpayChargeEur)
            .GreaterThanOrEqualTo(0).WithMessage("In-unpay charge EUR must be greater than or equal to 0.");

        RuleFor(x => x.OutUnpayChargeEur)
            .GreaterThanOrEqualTo(0).WithMessage("Out-unpay charge EUR must be greater than or equal to 0.");

        RuleFor(x => x.InUnpayChargeGbp)
            .GreaterThanOrEqualTo(0).WithMessage("In-unpay charge GBP must be greater than or equal to 0.");

        RuleFor(x => x.OutUnpayChargeGbp)
            .GreaterThanOrEqualTo(0).WithMessage("Out-unpay charge GBP must be greater than or equal to 0.");
    }
}

