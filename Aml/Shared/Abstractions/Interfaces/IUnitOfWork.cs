using Aml.Channels.Clearing.Features.Transactions.Abstractions.Repositories;

namespace Aml.Shared.Abstractions.Interfaces;

public interface IUnitOfWork
{
    ITransactionRepository TransactionRepository { get; }


    Task<int> CompleteAsync();

}
