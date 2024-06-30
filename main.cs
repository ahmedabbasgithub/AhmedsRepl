using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("************************************");
        Console.WriteLine("*  The stars shine in Greenville.  *");
        Console.WriteLine("************************************");

        bool exitRequested = false;

        while (!exitRequested)
        {
            DisplayMenu();

            int choice = GetMenuChoice();

            switch (choice)
            {
                case 1:
                    CalculateRevenue();
                    break;
                case 2:
                    exitRequested = true;
                    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Please Enter the following number below from the following menu:");
        Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
        Console.WriteLine("2. Exit");
    }

    static int GetMenuChoice()
    {
        Console.Write("Enter your choice: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                return choice;
            }
            else
            {
                Console.Write("Invalid input. Please enter a number: ");
            }
        }
    }

    static void CalculateRevenue()
    {
        Console.Write("Enter the number of contestants in the previous year: ");
        int lastYearContestants = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of contestants in the current year: ");
        int currentYearContestants = int.Parse(Console.ReadLine());

        decimal expectedRevenue = CalculateExpectedRevenue(currentYearContestants);

        Console.WriteLine($"Last year's competition had {lastYearContestants} contestants, and this year's has {currentYearContestants} contestants");
        Console.WriteLine($"Revenue expected this year is ${expectedRevenue.ToString("0.##")}");

        bool isBigger = currentYearContestants > lastYearContestants;
        Console.WriteLine($"It is {(isBigger ? "true" : "false")} that this year's competition is bigger than last year's.");
    }

    static decimal CalculateExpectedRevenue(int contestants)
    {
        decimal revenuePerContestant = 25.0m; // Example revenue per contestant
        return contestants * revenuePerContestant;
    }
}
