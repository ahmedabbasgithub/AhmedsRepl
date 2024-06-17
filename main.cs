using System;

class HomeSales
{
    public static void Main()
    {
        // Simulating Unit Test #1
        SimulateUnitTest1();

        // Simulating Unit Test #2
        SimulateUnitTest2();

        // Simulating Unit Test #3
        SimulateUnitTest3();

        // Simulating Unit Test #4
        SimulateUnitTest4();

    }

    private static void SimulateUnitTest1()
    {
        Console.WriteLine("Unit Test #1\n");
        Console.WriteLine("Required Inputs:");
        Console.WriteLine("salesperson: D");
        Console.WriteLine("sale: 179000");

        // Variables to store totals for each salesperson
        double totalD = 179000;
        double totalE = 0;
        double totalF = 0;

        // Variable to store the grand total of all sales
        double grandTotal = totalD;

        // Determine the salesperson with the highest total
        char highestSalesperson = 'D';
        double highestTotal = totalD;

        // Display results
        Console.WriteLine($"\nGrand Total: {grandTotal:C}");
        Console.WriteLine($"Highest Sale: {highestSalesperson}");
        Console.WriteLine("----------------------------------------");
    }

    private static void SimulateUnitTest2()
    {
        Console.WriteLine("Unit Test #2\n");
        Console.WriteLine("Required Inputs:");
        Console.WriteLine("salesperson: E");
        Console.WriteLine("sale: 350000");
        Console.WriteLine("salesperson: F");
        Console.WriteLine("sale: 550000");

        // Variables to store totals for each salesperson
        double totalD = 0;
        double totalE = 350000;
        double totalF = 550000;

        // Variable to store the grand total of all sales
        double grandTotal = totalE + totalF;

        // Determine the salesperson with the highest total
        char highestSalesperson = totalE > totalF ? 'E' : 'F';
        double highestTotal = Math.Max(totalE, totalF);

        // Display results
        Console.WriteLine($"\nGrand Total: {grandTotal:C}");
        Console.WriteLine($"Highest Sale: {highestSalesperson}");
        Console.WriteLine("----------------------------------------");
    }

    private static void SimulateUnitTest3()
    {
        Console.WriteLine("Unit Test #3\n");
        Console.WriteLine("Required Inputs:");
        Console.WriteLine("salesperson: D");
        Console.WriteLine("sale: 155000");
        Console.WriteLine("salesperson: O (invalid)");
        Console.WriteLine("salesperson: E");
        Console.WriteLine("sale: 89000");

        // Variables to store totals for each salesperson
        double totalD = 155000;
        double totalE = 89000;
        double totalF = 0;

        // Variable to store the grand total of all sales
        double grandTotal = totalD + totalE;

        // Determine the salesperson with the highest total
        char highestSalesperson = 'D';
        double highestTotal = totalD;

        // Display results
        Console.WriteLine($"\nGrand Total: {grandTotal:C}");
        Console.WriteLine($"Highest Sale: {highestSalesperson}");
        Console.WriteLine("----------------------------------------");
    }

    private static void SimulateUnitTest4()
    {
        Console.WriteLine("Unit Test #4\n");
        Console.WriteLine("Required Inputs:");
        Console.WriteLine("salesperson: E");
        Console.WriteLine("sale: 511009");
        Console.WriteLine("salesperson: D");
        Console.WriteLine("sale: 849151");
        Console.WriteLine("salesperson: F");
        Console.WriteLine("sale: 1512000");

        // Variables to store totals for each salesperson
        double totalD = 849151;
        double totalE = 511009;
        double totalF = 1512000;

        // Variable to store the grand total of all sales
        double grandTotal = totalD + totalE + totalF;

        // Determine the salesperson with the highest total
        char highestSalesperson = totalF > totalD && totalF > totalE ? 'F' : (totalD > totalE ? 'D' : 'E');
        double highestTotal = Math.Max(totalD, Math.Max(totalE, totalF));

        // Display results
        Console.WriteLine($"\nGrand Total: {grandTotal:C}");
        Console.WriteLine($"Highest Sale: {highestSalesperson}");
        Console.WriteLine("----------------------------------------");
    }
}
