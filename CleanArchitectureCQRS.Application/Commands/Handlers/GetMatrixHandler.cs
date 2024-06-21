using CQRSProject.Application.Services.WordMatrix;
using CQRSProject.Shared.Requests;
using CQRSProject.Shared.Responses;
using MediatR;

namespace CQRSProject.Application.Commands.Handlers;

/// <summary>
///     Handles get matrix requests.
/// </summary>
public class GetMatrixHandler : IRequestHandler<GetMatrixRequest, GetMatrixResponse>
{
    readonly IWordMatrix wordMatrix;
    public GetMatrixHandler(IWordMatrix wordMatrix) { 
        this.wordMatrix = wordMatrix;
    }

    /// <summary>
    ///     Handles get matrix requests.
    /// </summary>
    /// <param name="request">The get matrix request.</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The current matrix as a List of string</returns>
    public async Task<GetMatrixResponse> Handle(GetMatrixRequest request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(new GetMatrixResponse() { Matrix = wordMatrix.GetMatrix() });
    }
}
