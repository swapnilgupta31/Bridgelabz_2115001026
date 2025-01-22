using System;

public class FeeCalculator
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take student fee as input
        Console.WriteLine("Enter the student fee amount (INR): ");
        double fee = double.Parse(Console.ReadLine());

        // Take discount percentage as input
        Console.WriteLine("Enter the university discount percentage: ");
        double discountPercent = double.Parse(Console.ReadLine());

        // Calculate discount amount
        double discount = (discountPercent / 100) * fee;

        // Calculate final discounted fee
        double finalFee = fee - discount;

        // Print the result
        Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {finalFee:F2}");
    }
}
