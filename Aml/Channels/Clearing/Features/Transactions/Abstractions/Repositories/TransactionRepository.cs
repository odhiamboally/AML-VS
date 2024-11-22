
using Aml.Channels.Clearing.Features.Transactions.Contracts;
using Aml.Persistence.DataContext;
using Aml.Shared.Entitties;
using Aml.Shared.Enums;
using Dapper;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Reflection;

namespace Aml.Channels.Clearing.Features.Transactions.Abstractions.Repositories;

internal sealed class TransactionRepository : ITransactionRepository
{
    private readonly DBContext _context;
    private readonly DapperContext _dapper;
    private readonly IDbConnection _connection;

    public TransactionRepository(DBContext context, DapperContext dapper)
    {
        if (string.IsNullOrEmpty(context.Database.GetDbConnection().ConnectionString))
        {
            throw new InvalidOperationException("The ConnectionString property has not been initialized. Check your configuration.");
        }

        _dapper = dapper ?? throw new ArgumentNullException(nameof(dapper));
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _connection = _dapper.CreateConnection();
        
    }

    public async Task<int> BatchTransactionsAsync(BatchTransactionRequest batchTransactionRequest)
    {
        var parameters = new[]
        {
            new SqlParameter("@TranTypeId", batchTransactionRequest.TranTypeId),
            new SqlParameter("@SessionId", batchTransactionRequest.SessionId),
            new SqlParameter("@Success", SqlDbType.Bit) { Direction = ParameterDirection.Output },
            new SqlParameter("@ErrorMessage", SqlDbType.NVarChar, 255) { Direction = ParameterDirection.Output }
        };

        await _context.Database
            .ExecuteSqlInterpolatedAsync($"EXEC SP_BATCH_TRANSACTIONS_NEW {parameters[0]}, {parameters[1]}, {parameters[2]} OUTPUT, {parameters[3]} OUTPUT");

        // Retrieve output values after execution
        bool isSuccess = parameters[2].Value != DBNull.Value && (bool)parameters[2].Value;
        string errorMessage = parameters[3].Value?.ToString()!;

        return isSuccess ? 0 : 1;

    }

    public async Task<ValidateTransactionResponse> ValidateInEFTsAsync(ValidateTransactionRequest validateTransactionRequest)
    {
        ValidateTransactionResponse response = new();

        var sessionId = new SqlParameter("@SESSID", validateTransactionRequest.SessionId);

        var results = await _context.InCredits!
            .FromSqlInterpolated($"EXEC SP_VALIDATEINEFTSNEW3 {sessionId}")
            .ToListAsync();

        var returnReasons = await FetchReturnReasons().ToListAsync();
        //var returnReasons = await FetchReturnReasonsAsync();
        var returnReasonDict = returnReasons.ToDictionary(r => r.ReturnReasonId, r => r.ReturnReasonDesc); // Dictionary for quick lookup 

        // Map InCredits to ValidationResults
        var validationResults = results.Select(result => new ValidationResult
        {
            TransactionRef = result.InCreditId.ToString(),
            IsValid = result.ReturnReasonId == 4,
            MessageId = result.ReturnReasonId,
            Message = returnReasonDict.ContainsKey(result.ReturnReasonId)
                ? returnReasonDict[result.ReturnReasonId]
                : "Unknown Reason"
        }).ToList();

        response.ValidationResults.AddRange(validationResults);
        return response;
    }

    public async Task<ValidateTransactionResponse> ValidateTransactionsAsync(ValidateTransactionRequest validateTransactionRequest)
    {
        const string storedProcedure = "SP_EFTAML_VALIDATE";
        var response = new ValidateTransactionResponse();

        try
        {
            DynamicParameters parameters = new();
            parameters.Add("@ENTITY", validateTransactionRequest.Entity, DbType.String);

            var results = await _connection.QueryAsync<ValidationResult>(
                storedProcedure,
                parameters,
                commandType: CommandType.StoredProcedure
            );

            response.ValidationResults.AddRange(results.ToList());
        }
        catch (Exception)
        {
            throw;
        }

        return response;
    }

    public Task<Dictionary<bool, string>> ValidateMaxAmountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Dictionary<bool, string>> ValidateNewAccountAsync()
    {
        throw new NotImplementedException();
    }


    private IQueryable<ReturnReason> FetchReturnReasons()
    {

        return _context.ReturnReasons!.OrderBy(rr => rr.ReturnReasonId).AsNoTracking();

    }

    private async Task<List<ReturnReason>> FetchReturnReasonsAsync()
    {
        string tableName = GetTableName<ReturnReason>().ToString()!;

        string query = $"SELECT RETURNREASONID, RETURNREASONDESC FROM {tableName}";

        try
        {
            //using (var connection = new SqlConnection(_connection.ConnectionString)) 
            //{
            //    await connection.OpenAsync();
            //    var returnReasons = await connection.QueryAsync<ReturnReason>(query);
            //    return returnReasons.ToList();
            //}

            using (_connection)
            {
                _connection.Open();
                var returnReasons = await _connection.QueryAsync<ReturnReason>(query);
                return returnReasons.ToList();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    private static T GetTableName<T>()
    {
        var type = typeof(T);

        // Option 1: Check for TableAttribute (if applicable)
        var tableAttribute = type.GetCustomAttribute<TableAttribute>();
        if (tableAttribute != null)
        {
            return (T)Convert.ChangeType(tableAttribute.Name, typeof(T)); // Ensure return type matches T
        }

        // Option 2: Use convention (e.g., class name)
        return (T)Convert.ChangeType(type.Name, typeof(T)); // Ensure return type matches T
    }


}
