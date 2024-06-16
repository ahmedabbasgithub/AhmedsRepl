using System;

class Perfect
{
    static void Main()
    {
        RunUnitTests();
    }

    // Method to run unit tests
    static void RunUnitTests()
    {
        Console.WriteLine("Unit Test #1");
        CheckPerfectNumber(496, "Perfect Number");

        Console.WriteLine("\nUnit Test #2");
        CheckPerfectNumber(68, "Not A Perfect Number");

        Console.WriteLine("\nUnit Test #3");
        CheckPerfectNumber(5112, "Not A Perfect Number");

        Console.WriteLine("\nUnit Test #4");
        CheckPerfectNumber(8128, "Perfect Number");
    }

    // Method to check and print the outcome of a unit test
    static void CheckPerfectNumber(int number, string expectedOutcome)
    {
        string outcome = IsPerfectNumber(number) ? "Perfect Number" : "Not A Perfect Number";
        Console.WriteLine($"Required Inputs:  {number}");
        Console.WriteLine($"Expected Outcome: {expectedOutcome}");
        Console.WriteLine();
    }

    // Method to check if a number is perfect
    static bool IsPerfectNumber(int number)
    {
        int sum = 0;

        // Find all divisors of number (excluding itself) and calculate their sum
        for (int divisor = 1; divisor <= number / 2; divisor++)
        {
            if (number % divisor == 0)
            {
                sum += divisor;
            }
        }

        // Check if sum of divisors equals the number
        return sum == number;
    }
}
