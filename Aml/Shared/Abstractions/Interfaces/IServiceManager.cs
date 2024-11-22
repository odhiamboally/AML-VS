using Aml.Channels.Clearing.Features.Transactions.Abstractions.Services;

namespace Aml.Shared.Abstractions.Interfaces;

public interface IServiceManager
{
    ITransactionService TransactionService { get; }
}
