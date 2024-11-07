namespace Aml.Channels.IB.Features.Rules.Contracts;

public record RuleResponse
{
    public int Id { get; init; }
    public string? Description { get; init; }
}
