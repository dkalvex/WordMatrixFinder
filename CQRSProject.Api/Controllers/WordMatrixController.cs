using CQRSProject.Shared.Requests;
using CQRSProject.Shared.Responses;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSProject.Api.Controllers;

/// <summary>
///     Controller for handling matrix related requests.
/// </summary>
/// <param name="sender"> MediaTR's DI </param>
[Route("word-matrix")]
public class WordMatrixController(ISender sender) : BaseController
{
    /// <summary>
    ///    Handles the request to get te current matrix that the API is working with.
    /// </summary>
    /// <returns> The task result contains the <see cref="ActionResult{GetMatrixResponse}" /></returns>
    [Produces("application/json", "application/xml", Type = typeof(GetMatrixResponse))]
    [HttpGet()]
    public async Task<ActionResult<GetMatrixResponse>> GetAsync()
    {
        try
        {
            var request = new GetMatrixRequest();
            var response = await sender.Send(request);
            return Ok(response);
        }
        catch (ValidationException e)
        {
            return BadRequest(e.Errors);
        }
    }

    /// <summary>
    ///     Handles the request to set te current matrix that the API is working with.
    /// </summary>
    /// <param name="request">The new matrix to work with.</param>
    /// <returns> The task result contains the <see cref="ActionResult{GetMatrixResponse}" </returns>
    [Produces("application/json", "application/xml", Type = typeof(GetMatrixResponse))]
    [HttpPost("set-matrix")]
    public async Task<ActionResult<GetMatrixResponse>> SetMatrixAsync([FromBody] SetMatrixRequest request)
    {
        try
        {
            var response = await sender.Send(request);
            return Ok(response);
        }
        catch (ValidationException e)
        {
            return BadRequest(e.Errors);
        }
        
    }

    /// <summary>
    ///     Handles the request to check if the words are in the matrix.
    /// </summary>
    /// <param name="request"> The list of words to find in the matrix.</param>
    /// <returns> The task result contains the <see cref="ActionResult{FindResponse}" </returns>
    [Produces("application/json", "application/xml", Type = typeof(FindResponse))]
    [HttpPost("find")]
    public async Task<ActionResult<FindResponse>> FindAsync([FromBody] FindRequest request)
    {
        try
        {
            var response = await sender.Send(request);
            return Ok(response);
        }
        catch (ValidationException e)
        {
            return BadRequest(e.Errors);
        }
    }
}
