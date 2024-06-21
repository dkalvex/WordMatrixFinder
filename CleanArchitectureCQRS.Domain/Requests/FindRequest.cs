using CQRSProject.Shared.Responses;
using MediatR;

namespace CQRSProject.Shared.Requests;

/// <summary>
///     Represents a request to check of the words are in the matrix.
/// </summary>
public class FindRequest : IRequest<FindResponse>
{
    /// <summary>
    ///     Get or set the words to find in the matrix.
    /// </summary>
    public IEnumerable<string>? Words { get; set; }
}
