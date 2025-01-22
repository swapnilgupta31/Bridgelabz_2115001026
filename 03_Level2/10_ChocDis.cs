using System;

public class ChocolateDistribution
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take user input for number of chocolates and number of children
        Console.WriteLine("Enter the number of chocolates:");
        int numberOfChocolates = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the number of children:");
        int numberOfChildren = int.Parse(Console.ReadLine());
        
        // Calculate the number of chocolates each child gets and the remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;
        
        // Output the results using string concatenation
        Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild + 
                          " and the number of remaining chocolates is " + remainingChocolates);
    }
}
