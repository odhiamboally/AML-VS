using Aml.Channels.Clearing.Features.Transactions.Commands;
using Aml.Channels.Clearing.Features.Transactions.Contracts;
using Aml.Shared.Dtos;

namespace Aml.Channels.Clearing.Features.Transactions.Abstractions.Services;

public interface ITransactionService
{
    Task<Response<bool>> BatchTransactionsAsync(BatchTransactionRequest batchTransactionRequest);
    Task<Response<ValidateTransactionResponse>> ValidateInEFTsAsync(ValidateTransactionRequest validateTransactionRequest);
    Task<Response<ValidateTransactionResponse>> ValidateTransactionsAsync(ValidateTransactionRequest validateTransactionRequest);


    Task<Response<Dictionary<bool, string>>> ValidateMaxAmountAsync();
    Task<Response<Dictionary<bool, string>>> ValidateNewAccountAsync();
}
    
