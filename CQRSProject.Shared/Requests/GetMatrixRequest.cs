using CQRSProject.Shared.Responses;
using MediatR;

namespace CQRSProject.Shared.Requests;

/// <summary>
///     Represents a request to retrieve the matrix.
/// </summary>
public class GetMatrixRequest : IRequest<GetMatrixResponse>
{
}
