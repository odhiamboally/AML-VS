namespace Aml.Channels.Clearing.Features.Transactions.Contracts;

public record ValidateTransactionResponse
{
    public List<ValidationResult> ValidationResults { get; init; } = [];
}
