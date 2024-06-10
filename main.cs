using System;

class Hurricane
{
    static void Main(string[] args)
    {
        RunUnitTest(1, 152);
        RunUnitTest(2, 97.913);
        RunUnitTest(3, 70.55);
        RunUnitTest(4, 175.99);
    }

    static void RunUnitTest(int testNumber, double windSpeed)
    {
        string category = GetHurricaneCategory(windSpeed);

        Console.WriteLine($"Unit Test #{testNumber}");
        Console.WriteLine($"Required Inputs:  {windSpeed} mph");
        Console.WriteLine("Expected Outcome: " + GetExpectedOutcome(testNumber));
        Console.WriteLine();
    }

    static string GetExpectedOutcome(int testNumber)
    {
        switch (testNumber)
        {
            case 1:
                return "Category Four Hurricane";
            case 2:
                return "Category Two Hurricane";
            case 3:
                return "Not a Hurricane";
            case 4:
                return "Category Five Hurricane";
            default:
                return "Unknown";
        }
    }

    static string GetHurricaneCategory(double windSpeed)
    {
        if (windSpeed >= 157)
        {
            return "Category Five Hurricane";
        }
        else if (windSpeed >= 130)
        {
            return "Category Four Hurricane";
        }
        else if (windSpeed >= 111)
        {
            return "Category Three Hurricane";
        }
        else if (windSpeed >= 96)
        {
            return "Category Two Hurricane";
        }
        else if (windSpeed >= 74)
        {
            return "Category One Hurricane";
        }
        else
        {
            return "Not a Hurricane";
        }
    }
}
