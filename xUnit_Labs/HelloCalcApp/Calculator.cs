using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloCalcApp;

public class Calculator
{
    // 1. The History Feature (Restored!)
    public List<int> History { get; private set; }

    public Calculator()
    {
        History = new List<int>();
    }

    // 2. The Math Logic (Add/Subtract)
    public int Add(params int[] numbers)
    {
        int result = numbers.Sum();
        History.Add(result); // Save to history
        return result;
    }

    public int Subtract(params int[] numbers)
    {
        int result = numbers.Aggregate((a, b) => a - b);
        History.Add(result); // Save to history
        return result;
    }

    // 3. The Math Parsing Logic (Dictionary + Calculate)
    private static readonly Dictionary<char, Func<int, int, int>> _operations = new()
    {
        { '+', (a, b) => a + b },
        { '-', (a, b) => a - b }
    };

    public int Calculate(string input)
    {
        // Clean up
        input = input.Replace(" ", "");

        // Split into numbers
        string[] numbersStr = input.Split(_operations.Keys.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        // Extract operators
        char[] operators = input.Where(c => _operations.ContainsKey(c)).ToArray();

        // Start calculation
        int result = int.Parse(numbersStr[0]);

        // Loop through operators
        for (int i = 0; i < operators.Length; i++)
        {
            char opChar = operators[i];
            int nextNumber = int.Parse(numbersStr[i + 1]);

            if (_operations.TryGetValue(opChar, out var opFunc))
            {
                result = opFunc(result, nextNumber);
            }
            else
            {
                throw new ArgumentException($"Unsupported operator: {opChar}");
            }
        }

        // Save parsing result to history too!
        History.Add(result);

        return result;
    }
}