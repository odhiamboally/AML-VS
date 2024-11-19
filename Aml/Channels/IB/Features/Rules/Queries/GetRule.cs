using Aml.Channels.IB.Features.Rules.Contracts;
using Aml.Persistence.DataContext;
using Aml.Shared.Dtos;
using Carter;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Aml.Channels.IB.Features.Rules.Queries;

public static class GetRule
{
    public record Query : IRequest<Response<RuleResponse>>
    {
        public int Id { get; init; }
        public string? Description { get; init; }
    }

    internal sealed class Handler : IRequestHandler<Query, Response<RuleResponse>>
    {
        private readonly DBContext _context;

        public Handler(DBContext context)
        {
            _context = context;

        }


        public async Task<Response<RuleResponse>> Handle(Query request, CancellationToken cancellationToken)
        {
            var rulesResponse = await _context.Rules
                .Where(rule => rule.Id == request.Id)
                .Select(rule => new RuleResponse
                {
                    Id = rule.Id,
                    Description = rule.Description,
                }).FirstOrDefaultAsync();

            if (rulesResponse == null)
            {
                return Response<RuleResponse>.Failure("Rule not found");
            }

            return Response<RuleResponse>.Success("Success", rulesResponse);
        }
    }


    public class CreateRuleEndPoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("api/rule/getbyid/{int:id}", async (int id, ISender sender) =>
            {
                var query = new Query { Id = id };
                var result = await sender.Send(query);
                if (!result.Successful)
                {
                    return Results.NotFound(result.Exception);
                }

                return Results.Ok(result.Data);
            });
        }
    }
}
