using System;

public class ProfitCalculator
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take cost price as input
        Console.WriteLine("Enter the Cost Price (INR):");
        int cp = int.Parse(Console.ReadLine());

        // Take selling price as input
        Console.WriteLine("Enter the Selling Price (INR):");
        int sp = int.Parse(Console.ReadLine());

        // Calculate profit or loss
        int profit = sp - cp;

        // Calculate profit percentage
        double profitPercentage = ((double)profit / cp) * 100;

        // Print the result
        Console.WriteLine($"The Cost Price is INR {cp} and Selling Price is INR {sp}\nThe Profit is INR {profit} and the Profit Percentage is {profitPercentage:F2}%");
    }
}
