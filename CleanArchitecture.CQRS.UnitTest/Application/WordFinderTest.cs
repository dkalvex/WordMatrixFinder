using CQRSProject.Application.Services.WordMatrix;

namespace CQRSProject.UnitTest.Application;

/// <summary>
///     Test for WordMatrix service
/// </summary>
public class WordFinderTest
{
    private readonly IWordMatrix _wordMatrix;
    public WordFinderTest(){
        _wordMatrix = new WordMatrix();
    }

    /// <summary>
    ///     Test to Find words in the matrix.
    /// </summary>
    [Fact]
    public void FinWords() {
        var wordStream = new List<string> { "chill", "cold", "wind", "snow", "chill" };
        var result = _wordMatrix.Find(wordStream);
        Assert.Equal(3, result.Count());
        Assert.Contains("chill", result);
        Assert.Contains("cold", result);
        Assert.Contains("wind", result);
    }
}
