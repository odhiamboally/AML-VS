using Aml.Channels.Clearing.Features.Transactions.Contracts;
using Aml.Shared.Abstractions.Interfaces;
using Aml.Shared.Dtos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Aml.Channels.Clearing.Features.Transactions.Abstractions.Services;

internal sealed class TransactionService : ITransactionService
{
    private readonly IUnitOfWork _unitOfWork;


    public TransactionService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));  
    }

    public async Task<Response<bool>> BatchTransactionsAsync(BatchTransactionRequest batchTransactionRequest)
    {
        try
        {
            var result = await _unitOfWork.TransactionRepository.BatchTransactionsAsync(batchTransactionRequest);
            return await _unitOfWork.CompleteAsync() > 0
                ? Response<bool>.Success("Transactions batched Successfully", true)
                : Response<bool>.Failure("Transactions batching Failed", false);
        }
        catch (Exception)
        {

            throw;
        }
        
    }

    public async Task<Response<ValidateTransactionResponse>> ValidateInEFTsAsync(ValidateTransactionRequest validateTransactionRequest)
    {
        try
        {
            var result =  await _unitOfWork.TransactionRepository.ValidateInEFTsAsync(validateTransactionRequest);
            if (!result.ValidationResults.Any())
            {
                return Response<ValidateTransactionResponse>.Failure("No Vlaidation Results Available");
            }

            return await _unitOfWork.CompleteAsync() > 0
                ? Response<ValidateTransactionResponse>.Success("InEFTs validated Successfully", result)
                : Response<ValidateTransactionResponse>.Failure("InEFTs validation Failed");
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<Response<ValidateTransactionResponse>> ValidateTransactionsAsync(ValidateTransactionRequest validateTransactionRequest)
    {
        try
        {
            var result = await _unitOfWork.TransactionRepository.ValidateTransactionsAsync(validateTransactionRequest);
            if (!result.ValidationResults.Any())
            {
                return Response<ValidateTransactionResponse>.Failure("No Vlaidation Results Available");
            }

            return await _unitOfWork.CompleteAsync() > 0
                ? Response<ValidateTransactionResponse>.Success("Transactions AML-Validated Successfully", result)
                : Response<ValidateTransactionResponse>.Failure("Transactions AML-Validation Failed");
        }
        catch (Exception)
        {

            throw;
        }
    }

    public Task<Response<Dictionary<bool, string>>> ValidateMaxAmountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Response<Dictionary<bool, string>>> ValidateNewAccountAsync()
    {
        throw new NotImplementedException();
    }

    
}
