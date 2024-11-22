namespace Aml.Channels.Clearing.Features.Transactions.Contracts;

public record BatchTransactionResponse
{
    public int BatchCount { get; init; }
}
