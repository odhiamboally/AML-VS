using Aml.Shared.Enums;

namespace Aml.Channels.Clearing.Features.Transactions.Contracts;

public record BatchTransactionRequest
{
    public int TranTypeId { get; init; }
    public int SessionId { get; init; }
}
