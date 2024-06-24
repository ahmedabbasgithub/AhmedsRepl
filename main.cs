using System;

class TemperaturesComparison
{
    static void Main()
    {
        const int NUM_TEMPERATURES = 5;
        int[] temperatures = new int[NUM_TEMPERATURES];
        bool validInput = false;

        Console.WriteLine("Enter five daily Fahrenheit temperatures (between -30 and 130):");

        // Input temperatures
        for (int i = 0; i < NUM_TEMPERATURES; i++)
        {
            while (!validInput)
            {
                Console.Write($"Temperature {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int temp) && temp >= -30 && temp <= 130)
                {
                    temperatures[i] = temp;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine($"Error: Temperature {temp} is invalid. Please enter a valid temperature between -30 and 130.");
                }
            }
            validInput = false;
        }

        // Determine temperature trend
        bool isAscending = true;
        bool isDescending = true;

        for (int i = 1; i < NUM_TEMPERATURES; i++)
        {
            if (temperatures[i] > temperatures[i - 1])
            {
                isDescending = false;
            }
            else if (temperatures[i] < temperatures[i - 1])
            {
                isAscending = false;
            }
        }

        // Output based on temperature trend
        if (isAscending)
        {
            Console.WriteLine("Getting warmer");
        }
        else if (isDescending)
        {
            Console.WriteLine("Getting cooler");
        }
        else
        {
            Console.WriteLine("It's a mixed bag");
        }

        // Display temperatures
        Console.WriteLine($"5-day Temperature [{string.Join(", ", temperatures)}]");

        // Calculate and display average temperature
        double averageTemperature = CalculateAverage(temperatures);
        Console.WriteLine($"Average Temperature is {averageTemperature} degrees");
    }

    // Method to calculate average of temperatures
    static double CalculateAverage(int[] temperatures)
    {
        double sum = 0;
        foreach (int temp in temperatures)
        {
            sum += temp;
        }
        return sum / temperatures.Length;
    }
}
