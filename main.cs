using System;

class GreenvilleIdol
{
    static void Main()
    {
        int previousYearContestants = GetValidContestantCount("Enter the number of contestants from the previous year: ");
        int currentYearContestants = GetValidContestantCount("Enter the number of contestants for the current year: ");

        CompareContestants(previousYearContestants, currentYearContestants);
    }

    static int GetValidContestantCount(string prompt)
    {
        int count;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out count) && count >= 0 && count <= 30)
            {
                return count;
            }
            Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
        }
    }

    static void CompareContestants(int previous, int current)
    {
        if (current > 2 * previous)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (current > previous)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else if (current < previous)
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
        else
        {
            Console.WriteLine("The competition size is the same as last year.");
        }
    }
}
