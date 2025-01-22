using System;

public class TotalIncome
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take salary as input
        Console.WriteLine("Enter the salary:");
        double salary = double.Parse(Console.ReadLine());

        // Take bonus as input
        Console.WriteLine("Enter the bonus:");
        double bonus = double.Parse(Console.ReadLine());

        // Compute total income by adding salary and bonus
        double totalIncome = salary + bonus;

        // Output the total income with appropriate message using string concatenation
        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);
    }
}
