using System;

public class TotalIncome
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take salary input from the user
        Console.WriteLine("Enter your salary:");
        double salary = double.Parse(Console.ReadLine());

        // Take bonus input from the user
        Console.WriteLine("Enter your bonus:");
        double bonus = double.Parse(Console.ReadLine());

        // Calculate total income by adding salary and bonus
        double totalIncome = salary + bonus;

        // Print the results
        Console.WriteLine("The salary is INR " + salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + totalIncome);
    }
}
