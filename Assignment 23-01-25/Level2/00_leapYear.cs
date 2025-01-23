using System;

class LeapYear
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a year
        Console.WriteLine("Enter a year (>= 1582):");
        int year = int.Parse(Console.ReadLine());

        // Check if the year is valid
        if (year < 1582)
        {
            Console.WriteLine("The program only works for years >= 1582 (Gregorian calendar).");
            return;
        }

        // Part 1: Using multiple if-else statements
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("Year " + year + " is a Leap Year.");
                }
                else
                {
                    Console.WriteLine("Year " + year + " is not a Leap Year.");
                }
            }
            else
            {
                Console.WriteLine("Year " + year + " is a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine("Year " + year + " is not a Leap Year.");
        }

        // Part 2: Using a single if statement with multiple logical conditions
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            Console.WriteLine("Year " + year + " is a Leap Year.");
        }
        else
        {
            Console.WriteLine("Year " + year + " is not a Leap Year.");
        }
    }
}
