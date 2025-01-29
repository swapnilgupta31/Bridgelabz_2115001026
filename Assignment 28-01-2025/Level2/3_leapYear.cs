using System;
class LeapYearCheck
{
    // Method to check if a year is a leap year
    public static bool IsLeapYear(int year){
        // Check if the year is divisible by 4 but not by 100, or divisible by 400
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
    static void Main(string[] args) {
        // Take user input
        Console.WriteLine("Enter a year (>= 1582):");
        int year = int.Parse(Console.ReadLine());
        // Check if year is valid (Gregorian calendar starts from 1582)
        if (year < 1582){
            Console.WriteLine("Year must be 1582 or later.");
            return;
        }
        // Check if the year is a leap year and display the result
        if (IsLeapYear(year))
            Console.WriteLine(year + " is a Leap Year.");
        else
            Console.WriteLine(year + " is not a Leap Year.");
    }
}
