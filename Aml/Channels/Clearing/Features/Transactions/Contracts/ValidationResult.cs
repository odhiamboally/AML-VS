namespace Aml.Channels.Clearing.Features.Transactions.Contracts;

public record ValidationResult
{
    public string? TransactionRef { get; init; }
    public bool IsValid { get; init; }
    public string? Condition { get; init; }
    public int MessageId { get; init; }
    public string? Message { get; init; }
    
}
