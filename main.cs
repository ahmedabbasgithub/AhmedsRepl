using System;

class HomeSales
{
    public static void Main()
    {
        // Arrays to store salesperson names, allowed initials, and total sales
        string[] salespeople = { "Danielle", "Edward", "Francis" };
        char[] allowedInitials = { 'D', 'E', 'F' };
        double[] totalSales = new double[3]; // Initialized with default values of 0.0

        // Simulate Unit Tests
        SimulateUnitTest1(salespeople, allowedInitials, totalSales);
        SimulateUnitTest2(salespeople, allowedInitials, totalSales);
        SimulateUnitTest3(salespeople, allowedInitials, totalSales);
        SimulateUnitTest4(salespeople, allowedInitials, totalSales);
    }

    private static void SimulateUnitTest1(string[] salespeople, char[] allowedInitials, double[] totalSales)
    {
        Console.WriteLine("Unit Test #1\n");
        Console.WriteLine("Required Inputs:");
        Console.WriteLine("salesperson: D");
        Console.WriteLine("sale: 179000");

        ProcessSale('D', 179000, salespeople, allowedInitials, totalSales);

        // Expected Outcome: Grand Total: 179000, Highest Sale: D
    }

    private static void SimulateUnitTest2(string[] salespeople, char[] allowedInitials, double[] totalSales)
    {
        Console.WriteLine("Unit Test #2\n");
        Console.WriteLine("Required Inputs:");
        Console.WriteLine("salesperson: E");
        Console.WriteLine("sale: 350000");
        Console.WriteLine("salesperson: F");
        Console.WriteLine("sale: 550000");

        ProcessSale('E', 350000, salespeople, allowedInitials, totalSales);
        ProcessSale('F', 550000, salespeople, allowedInitials, totalSales);

        // Expected Outcome: Grand Total: $900,000, Highest Sale: F
    }

    private static void SimulateUnitTest3(string[] salespeople, char[] allowedInitials, double[] totalSales)
    {
        Console.WriteLine("Unit Test #3\n");
        Console.WriteLine("Required Inputs:");
        Console.WriteLine("salesperson: D");
        Console.WriteLine("sale: 155000");
        Console.WriteLine("salesperson: O (invalid)");
        Console.WriteLine("salesperson: E");
        Console.WriteLine("sale: 89000");

        ProcessSale('D', 155000, salespeople, allowedInitials, totalSales);
        ProcessSale('O', 0, salespeople, allowedInitials, totalSales); // 'O' is invalid, sale should not be processed
        ProcessSale('E', 89000, salespeople, allowedInitials, totalSales);

        // Expected Outcome: Grand Total: $244,000, Highest Sale: D
    }

    private static void SimulateUnitTest4(string[] salespeople, char[] allowedInitials, double[] totalSales)
    {
        Console.WriteLine("Unit Test #4\n");
        Console.WriteLine("Required Inputs:");
        Console.WriteLine("salesperson: E");
        Console.WriteLine("sale: 511009");
        Console.WriteLine("salesperson: D");
        Console.WriteLine("sale: 849151");
        Console.WriteLine("salesperson: F");
        Console.WriteLine("sale: 1512000");

        ProcessSale('E', 511009, salespeople, allowedInitials, totalSales);
        ProcessSale('D', 849151, salespeople, allowedInitials, totalSales);
        ProcessSale('F', 1512000, salespeople, allowedInitials, totalSales);

        // Expected Outcome: Grand Total: $2,872,160, Highest Sale: F
    }

    private static void ProcessSale(char initial, double saleAmount, string[] salespeople, char[] allowedInitials, double[] totalSales)
    {
        int index = Array.IndexOf(allowedInitials, initial);
        if (index != -1)
        {
            totalSales[index] += saleAmount;
        }
        else
        {
            Console.WriteLine($"Intermediate output: Error, invalid salesperson '{initial}' selected, please try again");
        }

        // Calculate grand total
        double grandTotal = 0;
        foreach (var sale in totalSales)
        {
            grandTotal += sale;
        }

        // Determine the salesperson with the highest total
        double highestTotal = 0;
        int highestIndex = -1;
        for (int i = 0; i < totalSales.Length; i++)
        {
            if (totalSales[i] > highestTotal)
            {
                highestTotal = totalSales[i];
                highestIndex = i;
            }
        }
        char highestSalesperson = allowedInitials[highestIndex];

        // Display results
        Console.WriteLine($"\nGrand Total: {grandTotal:C}");
        Console.WriteLine($"Highest Sale: {salespeople[highestIndex]}");
        Console.WriteLine("----------------------------------------");
    }
}
