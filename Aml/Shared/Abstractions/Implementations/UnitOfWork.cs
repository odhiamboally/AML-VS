using Aml.Channels.Clearing.Features.Transactions.Abstractions.Repositories;
using Aml.Persistence.DataContext;
using Aml.Shared.Abstractions.Interfaces;

namespace Aml.Shared.Abstractions.Implementations;

public class UnitOfWork : IUnitOfWork
{
    public ITransactionRepository TransactionRepository { get; private set; }

    private readonly DBContext _context;

    public UnitOfWork(ITransactionRepository ransactionRepository, DBContext context)
    {
        TransactionRepository = ransactionRepository;
        _context = context;
    }


    public Task<int> CompleteAsync()
    {
        var result = _context.SaveChangesAsync();
        return result;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);

    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _context.Dispose();
        }
    }
}
