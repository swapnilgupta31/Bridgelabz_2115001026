using System;
public class CalendarGenerator
{
    public static string GetMonthName(int month)
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        return months[month - 1];
    }

    public static int GetNumberOfDaysInMonth(int month, int year)
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Check for leap year in February
        if (month == 2 && IsLeapYear(year))
        {
            return 29;
        }
        return daysInMonth[month - 1];
    }

    public static bool IsLeapYear(int year)
    {
        // Leap year rule: A year is a leap year if it is divisible by 4, but not divisible by 100, unless it is divisible by 400.
        return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
    }

    public static int GetFirstDayOfMonth(int month, int year)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;

        return d0;
    }

    public static void DisplayCalendar(int month, int year)
    {
        // Get the month name and number of days in the month
        string monthName = GetMonthName(month);
        int numDays = GetNumberOfDaysInMonth(month, year);

        // Get the first day of the month
        int firstDay = GetFirstDayOfMonth(month, year);

        // Display the calendar header
        Console.WriteLine("    " + monthName + " " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        // Display leading spaces for the first week
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    ");
        }

        // Display the days of the month
        for (int day = 1; day <= numDays; day++)
        {
            Console.Write("{0,3} ", day);

            // Move to the next line after Saturday (7th day)
            if ((firstDay + day) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        // Ensure the calendar ends with a new line if the last day is not a Saturday
        if ((firstDay + numDays) % 7 != 0)
        {
            Console.WriteLine();
        }
    }

    public static void Main(string[] args)
    {
        // Take input from the user
        Console.Write("Enter the month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the year: ");
        int year = int.Parse(Console.ReadLine());

        // Display the calendar
        DisplayCalendar(month, year);
    }
}
