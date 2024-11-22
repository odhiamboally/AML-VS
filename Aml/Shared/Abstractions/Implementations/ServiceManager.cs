using Aml.Channels.Clearing.Features.Transactions.Abstractions.Services;
using Aml.Shared.Abstractions.Interfaces;

namespace Aml.Shared.Abstractions.Implementations;

public class ServiceManager : IServiceManager
{
    public ITransactionService TransactionService { get; }

    public ServiceManager(ITransactionService transactionService)
    {
        TransactionService = transactionService;
    }
}
