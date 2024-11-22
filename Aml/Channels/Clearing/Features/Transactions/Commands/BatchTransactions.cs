using Aml.Channels.Clearing.Entities;
using Aml.Channels.Clearing.Features.Transactions.Contracts;
using Aml.Channels.IB.Entities;
using Aml.Channels.IB.Features.Rules.Contracts;
using Aml.Persistence.DataContext;
using Aml.Shared.Abstractions.Interfaces;
using Aml.Shared.Dtos;
using Aml.Shared.Enums;
using Carter;
using FluentValidation;
using Mapster;
using MediatR;
using static Aml.Channels.Clearing.Features.Transactions.Commands.BatchTransactions;

namespace Aml.Channels.Clearing.Features.Transactions.Commands;

public static class BatchTransactions
{
    public record Command : IRequest<Response<int>>
    {
        public int TranTypeId { get; init; }
        public int SessionId { get; init; }
    }

    public class Validator : AbstractValidator<Command>
    {
        public Validator()
        {
            RuleFor(x => x.TranTypeId)
            .NotEmpty().WithMessage("TranType Type is required.");

            RuleFor(x => x.SessionId)
            .NotEmpty().WithMessage("Session ID is required.");
        }
    }

    internal sealed class Handler : IRequestHandler<Command, Response<int>>
    {
        private readonly DBContext _context;
        private readonly IServiceManager _serviceManager;
        private readonly IValidator<Command> _validator;

        public Handler(DBContext context, IServiceManager serviceManager, IValidator<Command> validator)
        {
            _context = context;
            _validator = validator;
            _serviceManager = serviceManager;

        }

        public async Task<Response<int>> Handle(Command request, CancellationToken cancellationToken)
        {
            var validationresult = _validator.Validate(request);
            if (!validationresult.IsValid)
            {
                return Response<int>.Failure("Request Object is Invalid. ", 0, new ValidationException(validationresult.ToString()));
            }

            //if (!_validator.Validate(request).IsValid)
            //{
            //    throw new ValidationException("Request Object is Invalid", errors: _validator.Validate(request).Errors);
            //}

            

            BatchTransactionRequest batchTransactionRequest = new()
            {
                TranTypeId = request.TranTypeId,
                SessionId = request.SessionId
            };

            var batchTransactionResponse = await _serviceManager.TransactionService.BatchTransactionsAsync(batchTransactionRequest);
            if (!batchTransactionResponse.Successful)
            {
                return Response<int>.Failure(batchTransactionResponse.Message!, 0);
            }

            ValidateTransactionRequest validationTransactionRequest = new()
            {
                TranTypeId = request.TranTypeId,
                SessionId = request.SessionId,
                Entity = "INCREDIT"
            };

            var inEFTValidationResponse = await _serviceManager.TransactionService.ValidateInEFTsAsync(validationTransactionRequest);
            if (!inEFTValidationResponse.Successful)
            {
                return Response<int>.Failure(inEFTValidationResponse.Message!, 0);
            }

            var amlValidationResponse =  await _serviceManager.TransactionService.ValidateTransactionsAsync(validationTransactionRequest);
            if (!amlValidationResponse.Successful)
            {
                return Response<int>.Failure(amlValidationResponse.Message!, 0);
            }

            return Response<int>.Success(amlValidationResponse.Message!, 1);

        }
    }
}

//public class BatchTransactionEndPoint : ICarterModule
//{
//    public void AddRoutes(IEndpointRouteBuilder app)
//    {
//        app.MapPost("api/batchtransaction/batchitems", async (BatchTransactionRequest request, ISender sender) =>
//        {
//            var command = request.Adapt<Command>();
//            var result = await sender.Send(command);
//            if (!result.Successful)
//            {
//                return Results.BadRequest(result.Exception);
//            }

//            return Results.Ok(result.Data);
//        });
//    }
//}
