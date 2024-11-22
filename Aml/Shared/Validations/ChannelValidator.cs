using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class ChannelValidator : AbstractValidator<Channel>
{
    public ChannelValidator()
    {
        RuleFor(x => x.ChannelName)
            .MaximumLength(20).WithMessage("ChannelName cannot exceed 20 characters.");

        RuleFor(x => x.ChannelValue)
            .MaximumLength(50).WithMessage("ChannelValue cannot exceed 50 characters.");

        RuleFor(x => x.ChannelDesc)
            .MaximumLength(100).WithMessage("ChannelDesc cannot exceed 100 characters.");
    }
}

