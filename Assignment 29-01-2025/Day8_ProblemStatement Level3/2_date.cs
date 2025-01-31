using System;
class DateArithmetic
{
    static void Main()
    {
        // Take user input for the date
        Console.WriteLine("Enter a date (dd-MM-yyyy): ");
        string inputDate = Console.ReadLine();

        // Parse the input string into a DateTime object
        DateTime date = DateTime.ParseExact(inputDate, "dd-MM-yyyy", null);

        // Add 7 days, 1 month, and 2 years
        DateTime newDate = date.AddDays(7).AddMonths(1).AddYears(2);

        // Subtract 3 weeks from the result
        newDate = newDate.AddDays(-21); // 3 weeks = 21 days

        // Display the final result
        Console.WriteLine("Final date after arithmetic: " + newDate.ToString("dd-MM-yyyy"));
    }
}
