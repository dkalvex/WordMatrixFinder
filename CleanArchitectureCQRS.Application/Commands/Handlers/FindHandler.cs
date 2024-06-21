using CQRSProject.Application.Services.WordMatrix;
using CQRSProject.Shared.Requests;
using CQRSProject.Shared.Responses;
using MediatR;

namespace CQRSProject.Application.Commands.Handlers;

/// <summary>
///     Handles find words in the matrix requests.
/// </summary>
public class FindHandler : IRequestHandler<FindRequest, FindResponse>
{
    private readonly IWordMatrix wordMatrix;
    public FindHandler(
        IWordMatrix wordMatrix
    ) { 
        this.wordMatrix = wordMatrix;
    }
    /// <summary>
    ///     Handles find words in the matrix requests.
    /// </summary>
    /// <param name="request">The find words request.</param>
    /// <param name="cancellationToken">The cancellation token</param>
    /// <returns>The words found in the matrix</returns>
    public async Task<FindResponse> Handle(FindRequest request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(new FindResponse() { Words = wordMatrix.Find(request.Words!) });
    }
}
