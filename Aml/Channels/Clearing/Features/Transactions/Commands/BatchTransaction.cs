using Aml.Channels.Clearing.Entities;
using Aml.Channels.Clearing.Features.Transactions.Contracts;
using Aml.Channels.IB.Entities;
using Aml.Channels.IB.Features.Rules.Contracts;
using Aml.Persistence.DataContext;
using Aml.Shared.Dtos;
using Aml.Shared.Enums;
using Carter;
using FluentValidation;
using Mapster;
using MediatR;
using static Aml.Channels.Clearing.Features.Transactions.Commands.BatchTransaction;

namespace Aml.Channels.Clearing.Features.Transactions.Commands;

public static class BatchTransaction
{
    public record Command : IRequest<Response<int>>
    {
        public FileType FileType { get; init; }
        public int UserId { get; init; }
        public int SessionId { get; init; }
    }

    public class Validator : AbstractValidator<Command>
    {
        public Validator()
        {

            RuleFor(x => x.FileType)
            .NotEmpty().WithMessage("File Type is required.");

            RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("User ID is required.");

            RuleFor(x => x.SessionId)
            .NotEmpty().WithMessage("Session ID is required.");
        }
    }

    internal sealed class Handler : IRequestHandler<Command, Response<int>>
    {
        private readonly DBContext _context;
        private readonly IValidator<Command> _validator;

        public Handler(DBContext context, IValidator<Command> validator)
        {
            _context = context;
            _validator = validator;

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
                return Response<int>.Failure("Request Object is Invalid. ", 0, new FluentValidation.ValidationException(validationresult.ToString()));
            }

            InCredit inCredit = new()
            {
                Id = request.Description,
            };

            var batchTransactionResult = await _context.AddAsync(rule);
            var result = await _context.SaveChangesAsync();

            return Response<int>.Success("Rule added successfully. ", rule.Id);

        }
    }
}

public class BatchTransactionEndPoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("api/transaction/batchitems", async (BatchTransactionRequest request, ISender sender) =>
        {
            var command = request.Adapt<Command>();
            var result = await sender.Send(command);
            if (!result.Successful)
            {
                return Results.BadRequest(result.Exception);
            }

            return Results.Ok(result.Data);
        });
    }
}
