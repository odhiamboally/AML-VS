using Aml.Channels.Clearing.Features.Transactions.Contracts;

namespace Aml.Channels.Clearing.Features.Transactions.Abstractions.Repositories;

public interface ITransactionRepository
{
    Task<int> BatchTransactionsAsync(BatchTransactionRequest batchTransactionRequest);
    Task<ValidateTransactionResponse> ValidateTransactionsAsync(ValidateTransactionRequest validateTransactionRequest);
    Task<ValidateTransactionResponse> ValidateInEFTsAsync(ValidateTransactionRequest validateTransactionRequest);
    Task<Dictionary<bool, string>> ValidateMaxAmountAsync();
    Task<Dictionary<bool, string>> ValidateNewAccountAsync();

}
