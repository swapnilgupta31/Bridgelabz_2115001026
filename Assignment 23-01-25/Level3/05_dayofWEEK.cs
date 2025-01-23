using System;

class DayOfWeekCalculator
{
    static void Main(string[] args)
    {
        // Check if the correct number of command-line arguments is provided
        if (args.Length != 3)
        {
            Console.WriteLine("Please provide three arguments: month, day, and year.");
            return;
        }

        // Parse the inputs
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);
        int year = int.Parse(args[2]);

        // Validate input for month and day
        if (month < 1 || month > 12)
        {
            Console.WriteLine("Invalid month. Please enter a value between 1 and 12.");
            return;
        }

        if (day < 1 || day > 31)
        {
            Console.WriteLine("Invalid day. Please enter a value between 1 and 31.");
            return;
        }

        if (year < 1582) // Ensure Gregorian calendar range
        {
            Console.WriteLine("Year must be 1582 or later.");
            return;
        }

        // Formula calculations
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (day + x + (31 * m0) / 12) % 7;

        // Output the result
        Console.WriteLine($"Day of the week (0 for Sunday, 1 for Monday, etc.): {d0}");
    }
}
