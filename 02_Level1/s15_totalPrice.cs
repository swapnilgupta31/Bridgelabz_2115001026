using System;

public class TotalPriceCalculator
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take unit price and quantity as input
        Console.WriteLine("Enter the unit price of the item:");
        double unitPrice = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the quantity of the item:");
        int quantity = int.Parse(Console.ReadLine());

        // Calculate total price
        double totalPrice = unitPrice * quantity;

        // Print the result using string concatenation
        Console.WriteLine("The total purchase price is INR " + totalPrice + 
                          " if the quantity is " + quantity + 
                          " and unit price is INR " + unitPrice);
    }
}
