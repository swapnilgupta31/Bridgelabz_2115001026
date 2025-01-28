using System;

class SpringSeason
{
    // Method to check if it's spring season
    static bool IsSpringSeason(int month, int day)
    {
        // Spring Season: March 20 (03/20) to June 20 (06/20)
        if ((month == 3 && day >= 20 && day <= 31) ||  // March: Days 20 to 31
            (month == 4 && day >= 1 && day <= 30) ||   // April: Full month
            (month == 5 && day >= 1 && day <= 31) ||   // May: Full month
            (month == 6 && day >= 1 && day <= 20))     // June: Days 1 to 20
        {
            return true;
        }

        return false;
    }

    static void Main(string[] args)
    {
        // Take input for month and day from the user
        Console.WriteLine("Enter the month (1-12):");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the day (1-31):");
        int day = int.Parse(Console.ReadLine());

        // Call the method to check if it's spring season
        bool isSpring = IsSpringSeason(month, day);

        // Output result
        if (isSpring)
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }
}
