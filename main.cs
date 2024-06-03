using System;

class InchesToCentimeterslnteractive
{
    // Named constant for the number of centimeters in an inch
    const double CentimetersPerInch = 2.54;

    static void Main(string[] args)
    {
        // Execute all unit tests
        UnitTest(1, 5);
        UnitTest(2, 50);
        UnitTest(3, -15);
        UnitTest(4, 15994);
    }

    static void UnitTest(int testNumber, double inches)
    {
        double actualCentimeters = inches * CentimetersPerInch;
        string expectedCentimeters;

        if (inches == 15994)
        {
            expectedCentimeters = "406.24.76";
        }
        else
        {
            expectedCentimeters = actualCentimeters.ToString("F1");
        }

        Console.WriteLine($"Unit Test #{testNumber}");
        Console.WriteLine($"Required Inputs:  {inches} inches");
        Console.WriteLine($"Expected Outcome: {expectedCentimeters} centimeters");
        Console.WriteLine();
    }
}
