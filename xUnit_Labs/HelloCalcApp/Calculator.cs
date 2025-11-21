using System.Linq; // Needed for .Sum() and .Aggregate()

namespace HelloCalcApp;

public class Calculator
{
    // Updated to accept a list of numbers
    public int Add(params int[] numbers)
    {
        return numbers.Sum();
    }

    // Updated to subtract a list of numbers sequentially
    public int Subtract(params int[] numbers)
    {
        // Uses Aggregate to subtract the next number from the previous result
        return numbers.Aggregate((a, b) => a - b);
    }
}