using Aml.Shared.Entitties;
using FluentValidation;

namespace Aml.Shared.Validations;

public class OutDebitValidator : AbstractValidator<OutDebit>
{
    public OutDebitValidator()
    {
        RuleFor(x => x.ProcNo).NotEmpty().Length(1, 20);
        RuleFor(x => x.CustAccount).NotEmpty().Length(1, 25);
        RuleFor(x => x.CustName).NotEmpty();
        RuleFor(x => x.AccountNo).NotEmpty().Length(1, 25);
        RuleFor(x => x.BeneficiaryName).NotEmpty();
        RuleFor(x => x.OriginatorRef).NotEmpty().Length(1, 35);
        RuleFor(x => x.Amount).GreaterThan(0);
        RuleFor(x => x.SignDate).NotEmpty();
    }
}

