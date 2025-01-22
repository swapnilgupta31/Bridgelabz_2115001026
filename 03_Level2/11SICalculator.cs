using System;

public class SimpleInterestCalculator
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take user input for principal, rate, and time
        Console.WriteLine("Enter the principal amount:");
        double principal = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the rate of interest:");
        double rate = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the time in years:");
        double time = double.Parse(Console.ReadLine());
        
        // Calculate Simple Interest using the formula
        double simpleInterest = (principal * rate * time) / 100;
        
        // Output the results using string concatenation
        Console.WriteLine("The Simple Interest is " + simpleInterest + " for Principal " + principal + 
                          ", Rate of Interest " + rate + " and Time " + time);
    }
}
