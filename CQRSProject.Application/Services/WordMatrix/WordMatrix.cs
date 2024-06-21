namespace CQRSProject.Application.Services.WordMatrix;

/// <summary>
///     Represents a word matrix implementation.
/// </summary>
public class WordMatrix : IWordMatrix
{
    private char[,]? _matrix;
    private int rows;
    private int cols;

    /// <summary>
    ///     Initializes a new instance of the <see cref="WordMatrix"/> class and defined default values.
    /// </summary>
    public WordMatrix()
    {
        List<string> matrix = new List<string> { "abcgc", "fgwio", "chill", "pqnsd", "uvdxy" };
        SetMatrix(matrix);
    }

    /// <inheritdoc />
    public IEnumerable<string> Find(IEnumerable<string> wordstream)
    {
        List<string> foundWords = new List<string>();

        foreach (var word in wordstream.Distinct())
        {
            if (WordExists(word))
            {
                foundWords.Add(word);
            }
        }

        return foundWords;
    }

    /// <inheritdoc />
    public void SetMatrix(IEnumerable<string> matrix)
    {
        rows = matrix.Count();
        cols = matrix.ToList()[0].Length;
        _matrix = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                _matrix[i, j] = matrix.ToList()[i][j];
            }
        }
    }

    /// <inheritdoc />
    private bool WordExists(string word)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (SearchHorizontally(word, i, j) || SearchVertically(word, i, j))
                {
                    return true;
                }
            }
        }

        return false;
    }

    /// <summary>
    ///     Checks if a word exists horizontally or vertically in the matrix.
    /// </summary>
    /// <param name="word">The word to search for.</param>
    /// <returns>true if the word exists in the matrix; otherwise, false.</returns>

    private bool SearchHorizontally(string word, int row, int col)
    {
        if (col + word.Length > cols)
        {
            return false;
        }

        for (int k = 0; k < word.Length; k++)
        {
            if (_matrix![row, col + k] != word[k])
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    ///     Searches for a word horizontally in the matrix.
    /// </summary>
    /// <param name="word">The word to search for.</param>
    /// <param name="row">The starting row index.</param>
    /// <param name="col">The starting column index.</param>
    /// <returns>true if the word is found horizontally; otherwise, false.</returns>
    private bool SearchVertically(string word, int row, int col)
    {
        if (row + word.Length > rows)
        {
            return false;
        }

        for (int k = 0; k < word.Length; k++)
        {
            if (_matrix![row + k, col] != word[k])
            {
                return false;
            }
        }

        return true;
    }

    /// <inheritdoc />
    public IEnumerable<string> GetMatrix()
    {
        return ConvertMatrixToList(_matrix!);
    }

    /// <summary>
    ///     Converts the matrix from char[,] to list of string.
    /// </summary>
    /// <param name="matrix">The char[,] matrix to convert.</param>
    /// <returns>A list of strings representing the matrix rows.</returns>
    static List<string> ConvertMatrixToList(char[,] matrix)
    {
        List<string> list = new List<string>();

        for (int i = 0; i < matrix.GetLength(0); i++) // Row
        {
            char[] row = new char[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++) // Columns
            {
                row[j] = matrix[i, j];
            }
            list.Add(new string(row));
        }

        return list;
    }
}
