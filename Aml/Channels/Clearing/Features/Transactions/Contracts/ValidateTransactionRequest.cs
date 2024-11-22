using Aml.Shared.Enums;

namespace Aml.Channels.Clearing.Features.Transactions.Contracts;

public record ValidateTransactionRequest
{
    public FileType FileType { get; init; }
    public string? Entity { get; init; }
    public int TranTypeId { get; init; }
    public int SessionId { get; init; }
}
