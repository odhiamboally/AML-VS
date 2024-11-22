using Aml.Channels.Clearing.Features.Transactions.Contracts;
using Aml.Shared.Abstractions.Interfaces;
using Aml.Shared.Dtos;
using Aml.Shared.Enums;
using FluentValidation;
using MediatR;

namespace Aml.Channels.Clearing.Features.Transactions.Commands;

public static class ValidateTransactions
{
    public record Command : IRequest<Response<int>>
    {
        public FileType FileType { get; init; }
        public int TranTypeId { get; init; }
        public int SessionId { get; init; }
    }

    public class Validator : AbstractValidator<Command>
    {
        public Validator()
        {
            RuleFor(x => x.FileType)
            .NotEmpty().WithMessage("File Type is required.");

            RuleFor(x => x.SessionId)
            .NotEmpty().WithMessage("Session ID is required.");
        }
    }

    internal sealed class Handler : IRequestHandler<Command, Response<int>>
    {
        private readonly IServiceManager _serviceManager;
        private readonly IValidator<Command> _validator;

        public Handler(IServiceManager serviceManager, IValidator<Command> validator)
        {
            _validator = validator;
            _serviceManager = serviceManager;

        }

        public async Task<Response<int>> Handle(Command request, CancellationToken cancellationToken)
        {
            var validationresult = _validator.Validate(request);
            if (!_validator.Validate(request).IsValid)
            {
                throw new ValidationException("Request Object is Invalid", errors: _validator.Validate(request).Errors);
            }

            if (!validationresult.IsValid)
            {
                return Response<int>.Failure("Request Object is Invalid. ", 0, new ValidationException(validationresult.ToString()));
            }

            ValidateTransactionRequest validateTransactionRequest = new()
            {
                TranTypeId = request.TranTypeId,
                SessionId = request.SessionId
            };

            var validationResponse = await _serviceManager.TransactionService.ValidateTransactionsAsync(validateTransactionRequest);
            if (!validationResponse.Successful)
            {
                return Response<int>.Failure(validationResponse.Message!, 0);
            }

            return Response<int>.Success("Transactions bathed successfully. ", 1);

        }
    }
}
