using System;

class InchesToCentimeters
{
    // Named constant for the number of centimeters in an inch
    const double CentimetersPerInch = 2.54;

    static void Main(string[] args)
    {
        // Execute all unit tests
        UnitTest1();
        UnitTest2();
        UnitTest3();
        UnitTest4();
    }

    // Unit Test #1
    static void UnitTest1()
    {
        double inches = 5;
        double expectedCentimeters = 12.7;
        double actualCentimeters = inches * CentimetersPerInch;
        Console.WriteLine("Unit Test #1");
        Console.WriteLine($"Required Inputs:  {inches} inches");
        Console.WriteLine($"Expected Outcome: {expectedCentimeters} centimeters");
        Console.WriteLine();
    }

    // Unit Test #2
    static void UnitTest2()
    {
        double inches = 50;
        double expectedCentimeters = 127;
        double actualCentimeters = inches * CentimetersPerInch;
        Console.WriteLine("Unit Test #2");
        Console.WriteLine($"Required Inputs:  {inches} inches");
        Console.WriteLine($"Expected Outcome: {expectedCentimeters} centimeters");
        Console.WriteLine();
    }

    // Unit Test #3
    static void UnitTest3()
    {
        double inches = -15;
        double expectedCentimeters = -38.1;
        double actualCentimeters = inches * CentimetersPerInch;
        Console.WriteLine("Unit Test #3");
        Console.WriteLine($"Required Inputs:  {inches} inches");
        Console.WriteLine($"Expected Outcome: {expectedCentimeters} centimeters");
        Console.WriteLine();
    }

    // Unit Test #4
    static void UnitTest4()
    {
        double inches = 15994;
        double expectedCentimeters = 40624.76;
        double actualCentimeters = inches * CentimetersPerInch / 100.0; // Convert inches to meters
        Console.WriteLine("Unit Test #4");
        Console.WriteLine($"Required Inputs:  {inches} inches");
        Console.WriteLine($"Expected Outcome: {expectedCentimeters} centimeters");
        Console.WriteLine();
    }
}
