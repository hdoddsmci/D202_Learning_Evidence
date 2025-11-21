using System.Collections.Generic; // Needed for List
using System.Linq;

namespace HelloCalcApp;

public class Calculator
{
    // 1. Create the History property
    public List<int> History { get; private set; }

    // 2. Initialize it in the Constructor
    public Calculator()
    {
        History = new List<int>();
    }

    public int Add(params int[] numbers)
    {
        int result = numbers.Sum();

        // 3. Save to History
        History.Add(result);

        return result;
    }

    public int Subtract(params int[] numbers)
    {
        int result = numbers.Aggregate((a, b) => a - b);

        // 3. Save to History (Optional, but good practice)
        History.Add(result);

        return result;
    }
}