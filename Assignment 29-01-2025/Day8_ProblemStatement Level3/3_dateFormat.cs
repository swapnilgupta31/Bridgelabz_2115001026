using System;
class DateFormattingExample
{
    static void Main()
    {
        // Get the current date and time
        DateTime currentDate = DateTime.Now;

        // Display the current date in different formats
        Console.WriteLine("Current Date in dd/MM/yyyy format: " + currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Current Date in yyyy-MM-dd format: " + currentDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Current Date in EEE, MMM dd, yyyy format: " + currentDate.ToString("ddd, MMM dd, yyyy"));
    }
}
