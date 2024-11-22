using Aml.Channels.Clearing.Features.Transactions.Commands;
using Aml.Channels.Clearing.Features.Transactions.Contracts;
using Aml.Shared.Dtos;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aml.Channels.Clearing.Features.Transactions.Controllers;


[Route("api/[controller]")]
[ApiController]
public class TransactionController : ControllerBase
{
    private readonly ISender _sender;

    public TransactionController(ISender sender)
    {
        _sender = sender;
            
    }

    [HttpPost("batchitems")]
    public async Task<ActionResult<BatchTransactionResponse>> BatchTransactions([FromBody] BatchTransactionRequest batchTransactionRequest)
    {
        BatchTransactionResponse batchTransactionResponse = null!;
        var command = batchTransactionRequest.Adapt<BatchTransactions.Command>();
        var response = await _sender.Send(command);
        if (!response.Successful)
        {
            // Return 500 Internal Server Error for an unexpected failure
            if (response.Data <= 0)
                return Problem(
                    detail: response.Message!.ToString(),
                    statusCode: StatusCodes.Status500InternalServerError,
                    title: "An unexpected error occurred",
                    instance: HttpContext.Request.Path
                );

            batchTransactionResponse = new()
            {
                BatchCount = response.Data,
            };

            return BadRequest(batchTransactionResponse);
        }

        return Ok(batchTransactionResponse);
    }


}
