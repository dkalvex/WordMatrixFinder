namespace CQRSProject.Shared.Responses;

/// <summary>
///     Represnt the find word in matrix response.
/// </summary>
public class FindResponse
{
    /// <summary>
    ///  Get or set the word found in the matrix.
    /// </summary>
    public IEnumerable<string>? Words { get; set; }
}
