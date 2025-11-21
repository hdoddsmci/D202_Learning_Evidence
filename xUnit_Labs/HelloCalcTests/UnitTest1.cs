using Xunit;
using HelloCalcApp; // This allows us to see the main app

namespace HelloCalcTests;

public class CalculatorTests
{
    [Fact]
    public void Add_GivenTwoNumbers_ReturnsSum()
    {
        // Arrange
        var calc = new Calculator(); // This might show a red error line (Good!)

        // Act
        var result = calc.Add(2, 3);

        // Assert
        Assert.Equal(5, result);
    }
}