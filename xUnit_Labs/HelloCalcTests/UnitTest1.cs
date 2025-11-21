using Xunit;
using HelloCalcApp;
using System.Linq; // Needed for the Average() test

namespace HelloCalcTests;

public class CalculatorTests
{
    // 1. The AAA Pattern Example
    [Fact]
    public void CanAddNumbers()
    {
        // Arrange
        int num1 = 2;
        int num2 = 3;
        var calc = new Calculator(); // Using our class

        // Act
        int result = calc.Add(num1, num2);

        // Assert
        Assert.Equal(5, result);
    }

    // 2. A More Complex Test (Arrays)
    [Fact]
    public void CanCalculateAverage()
    {
        // Arrange
        var numbers = new int[] { 2, 3, 5, 7, 11 };

        // Act
        double average = numbers.Average();

        // Assert
        Assert.Equal(5.6, average, 1); // The '1' is precision (decimal places)
    }

    // 3. Parameterized Test (The Theory)
    [Theory]
    [InlineData(3, 7, 10)]
    [InlineData(-3, -7, -10)]
    [InlineData(100, 200, 300)]
    public void CanAddNumbersParameterized(int num1, int num2, int expected)
    {
        // Arrange
        var calc = new Calculator();

        // Act
        int result = calc.Add(num1, num2);

        // Assert
        Assert.Equal(expected, result);
    }
    [Fact]
    public void TestToolkitChecklist()
    {
        // 1. False
        bool isComplete = false;
        Assert.False(isComplete);

        // 2. Null / NotNull
        object myObject = null;
        Assert.Null(myObject);

        myObject = new object();
        Assert.NotNull(myObject);

        // 3. Contains
        int[] numbers = new int[] { 1, 2, 3, 42 };
        Assert.Contains(42, numbers);

        // 4. InRange
        int actualValue = 5;
        Assert.InRange(actualValue, 1, 10);

        // 5. Empty / NotEmpty
        int[] emptyList = new int[] { };
        Assert.Empty(emptyList);
        Assert.NotEmpty(numbers);
    }
}