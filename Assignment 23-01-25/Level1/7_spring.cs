using System;

class Spring
{
    static void Main(string[] args)
    {
        // Prompt the user for the month
        Console.WriteLine("Enter the month number:");

        // Get input value for the month
        int month = int.Parse(Console.ReadLine());

        // Prompt the user for the date
        Console.WriteLine("Enter the date:");

        // Get input value for the date
        int date = int.Parse(Console.ReadLine());

        // Check if it's Spring Season and display the result
        if ((month == 3 && date >= 20 && date <= 31) || 
            (month == 4) || 
            (month == 5) || 
            (month == 6 && date >= 1 && date <= 20))
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }
}
