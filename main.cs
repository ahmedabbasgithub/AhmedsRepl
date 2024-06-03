using System;

class MoveEstimator
{
    static void Main(string[] args)
    {
        // Execute all unit tests
        UnitTest(1, 10, 600, 2900.00);
        UnitTest(2, 6.77, 15, 1245.50);
        UnitTest(3, 56.25, 325, 9287.50);
        UnitTest(4, 103, 3000, 21650.00);
    }

    static void UnitTest(int testNumber, double hours, double miles, double expectedOutcome)
    {
        double totalFee = CalculateMovingFee(hours, miles);

        Console.WriteLine($"Unit Test #{testNumber}");
        Console.WriteLine($"Required Inputs:");
        Console.WriteLine($"{hours} hours");
        Console.WriteLine($"{miles} miles");
        Console.WriteLine($"Expected Outcome: ${expectedOutcome:F2}");
        Console.WriteLine();
    }

    static double CalculateMovingFee(double hours, double miles)
    {
        const double baseRate = 200;
        const double hourlyRate = 150;
        const double perMileRate = 2;

        double totalFee = baseRate + (hourlyRate * hours) + (perMileRate * miles);
        return totalFee;
    }
}
