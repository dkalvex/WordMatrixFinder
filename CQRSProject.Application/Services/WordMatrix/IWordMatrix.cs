namespace CQRSProject.Application.Services.WordMatrix;

/// <summary>
///     Represents an interface for managing a word matrix.
/// </summary>
public interface IWordMatrix
{
    /// <summary>
    ///     Sets the matrix with the provided collection of strings.
    /// </summary>
    /// <param name="matrix">The collection of strings to set as the matrix.</param>
    void SetMatrix(IEnumerable<string> matrix);

    /// <summary>
    ///     Finds the specified words in the matrix.
    /// </summary>
    /// <param name="wordstream">The collection of words to find in the matrix.</param>
    /// <returns>A collection of found words.</returns>
    IEnumerable<string> Find(IEnumerable<string> wordstream);

    /// <summary>
    ///     Gets the current matrix.
    /// </summary>
    /// <returns>A collection of strings representing the current matrix.</returns>
    IEnumerable<string> GetMatrix();

}
