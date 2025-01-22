using System;

public class fees
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take fees as input 
        Console.WriteLine("Enter the fees amount: ");
        int fees = int.Parse(Console.ReadLine());

        // Take discount percentage as input 
        Console.WriteLine("Enter the discount percentage(%): ");
        int disPercentage = int.Parse(Console.ReadLine());

        // Calculate discount amount 
        double discount = ((double)disPercentage / 100) * fees;

        // Calculate discounted fees 
        double disFees = fees - discount;

        // Print the result
        Console.WriteLine($"The discount amount is INR {discount:F2} and the final discounted fee is INR {disFees:F2}");
    }
}
