using Aml.Shared.Enums;

namespace Aml.Channels.Clearing.Features.Transactions.Contracts;

public record BatchTransactionRequest
{
    public FileType FileType { get; init; }
    public int UserId { get; init; }
    public int SessionId { get; init; }
}
