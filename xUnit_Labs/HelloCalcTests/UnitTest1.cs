using Xunit;
using HelloCalcApp; // This allows us to see the main app

namespace HelloCalcTests;

public class CalculatorTests
{
    [Fact]
    public void TwoPlusTwo_Equals_Four()
    {
        // Arrange
        int result = 2 + 2;

        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void TwoPlusTwo_NotEquals_Five()
    {
        // Arrange
        int result = 2 + 2;

        // Assert
        Assert.NotEqual(5, result);
    }
}