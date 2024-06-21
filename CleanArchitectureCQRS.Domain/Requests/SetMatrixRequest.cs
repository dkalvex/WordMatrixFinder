using CQRSProject.Shared.Responses;
using MediatR;

namespace CQRSProject.Shared.Requests;

/// <summary>
///     Represents a request to set the matrix.
/// </summary>
public class SetMatrixRequest : IRequest<GetMatrixResponse>
{
    public IEnumerable<string>? Matrix { get; set; }
}
