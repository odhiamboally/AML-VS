using Aml.Channels.IB.Entities;
using Aml.Shared.Dtos;
using MediatR;
using System.Runtime.CompilerServices;
using static Aml.Channels.IB.Features.Rules.Commands.CreateRule;
using Carter;
using FluentValidation;
using System.Data;
using System.ComponentModel.DataAnnotations;
using Aml.Channels.IB.Features.Rules.Contracts;
using Mapster;
using Aml.Persistence.DataContext;

namespace Aml.Channels.IB.Features.Rules.Commands;

public static class CreateRule
{
    public record Command : IRequest<Response<int>>
    {
        public string? Description { get; init; } 
    }

    //Validation
    public class Validator : AbstractValidator<Command> 
    { 
        public Validator() 
        {

            RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Initiator BIC is required.");
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
                throw new FluentValidation.ValidationException("Request Object is Invalid", errors: _validator.Validate(request).Errors);
            }

            if (!validationresult.IsValid)
            {
                return Response<int>.Failure("Request Object is Invalid. ", 0, new FluentValidation.ValidationException(validationresult.ToString()));
            }

            IBRule rule = new()
            {
                Description = request.Description,
            };

            var addRuleResult = await _context.AddAsync(rule);
            var result = await _context.SaveChangesAsync();

            return Response<int>.Success("Rule added successfully. ", rule.Id);

        }
    }
}

public class CreateRuleEndPoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("api/rule/create", async (CreateRuleRequest request, ISender sender) =>
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




