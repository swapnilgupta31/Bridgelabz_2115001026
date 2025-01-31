using System;
class DateComparisonExample
{
    static void Main()
    {
        // Get the first date input from the user
        Console.WriteLine("Enter the first date (dd-MM-yyyy): ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

        // Get the second date input from the user
        Console.WriteLine("Enter the second date (dd-MM-yyyy): ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);

        // Compare the two dates
        int comparisonResult = firstDate.CompareTo(secondDate);

        // Display the result of the comparison
        if (comparisonResult < 0)
        {
            Console.WriteLine("The first date is before the second date.");
        }
        else if (comparisonResult > 0)
        {
            Console.WriteLine("The first date is after the second date.");
        }
        else
        {
            Console.WriteLine("Both dates are the same.");
        }
    }
}
