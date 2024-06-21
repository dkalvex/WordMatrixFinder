namespace CQRSProject.Shared.Responses;

/// <summary>
///  Represent the matrix as a list of string.
/// </summary>
public class GetMatrixResponse
{
    public IEnumerable<string>? Matrix { get; set; }
}
