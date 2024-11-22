using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        // UserName is required and must be between 1 and 20 characters
        RuleFor(u => u.UserName)
            .NotEmpty().WithMessage("UserName is required.")
            .Length(1, 20).WithMessage("UserName must be between 1 and 20 characters.");

        // Surname is required and must be between 1 and 30 characters
        RuleFor(u => u.Surname)
            .NotEmpty().WithMessage("Surname is required.")
            .Length(1, 30).WithMessage("Surname must be between 1 and 30 characters.");

        // OtherNames is required
        RuleFor(u => u.OtherNames)
            .NotEmpty().WithMessage("OtherNames is required.");

        // Password is required
        RuleFor(u => u.Password)
            .NotEmpty().WithMessage("Password is required.");

        // LoggedInSession is required
        RuleFor(u => u.LoggedInSession)
            .NotEmpty().WithMessage("LoggedInSession is required.");

        // Email must be a valid email format if provided
        RuleFor(u => u.Email)
            .EmailAddress().When(u => !string.IsNullOrEmpty(u.Email)).WithMessage("Invalid email format.");

        // PhoneNo must be in a valid phone number format if provided
        RuleFor(u => u.PhoneNo)
            .Matches(@"^\+?[0-9]*$").When(u => !string.IsNullOrEmpty(u.PhoneNo)).WithMessage("Invalid phone number format.");

        // LastPassChange and LastLogin must be valid dates
        RuleFor(u => u.LastPassChange)
            .LessThanOrEqualTo(DateTime.Now).WithMessage("LastPassChange must be in the past.");

        RuleFor(u => u.LastLogin)
            .LessThanOrEqualTo(DateTime.Now).WithMessage("LastLogin must be in the past.");

        // TokenName is optional but must be between 0 and 100 characters if provided
        RuleFor(u => u.TokenName)
            .MaximumLength(100).WithMessage("TokenName must be no longer than 100 characters.");
    }
}