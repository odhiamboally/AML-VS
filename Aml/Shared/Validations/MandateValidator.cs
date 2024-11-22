namespace Aml.Shared.Validations;

using Aml.Shared.Entitties;
using FluentValidation;

public class MandateValidator : AbstractValidator<Mandate>
{
    public MandateValidator()
    {
        RuleFor(m => m.AccountNo)
            .NotEmpty().WithMessage("Account number is required.");

        RuleFor(m => m.MandateName)
            .NotEmpty().WithMessage("Mandate name is required.")
            .Length(1, 100).WithMessage("Mandate name must be between 1 and 100 characters.");

        RuleFor(m => m.MandateText)
            .NotEmpty().WithMessage("Mandate text is required.");

        RuleFor(m => m.SignatureUrl)
            .NotEmpty().WithMessage("Signature URL is required.");

        RuleFor(m => m.StatusId)
            .GreaterThan(0).WithMessage("Status ID must be greater than 0.");

        RuleFor(m => m.SignatureImage)
            .Must(BeValidSignatureImage!).WithMessage("Signature image is invalid.");  // Custom validation
    }

    private bool BeValidSignatureImage(byte[] signatureImage)
    {
        // Implement custom signature image validation if needed
        return signatureImage == null || signatureImage.Length > 0;  // Allow null or non-empty byte array
    }
}
