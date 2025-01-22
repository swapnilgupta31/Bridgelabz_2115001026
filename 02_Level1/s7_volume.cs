using System;

public class volume
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take radius as input 
        Console.WriteLine("Enter the radies of the planet");
        int radius = int.Parse(Console.ReadLine());
        
        // Calculate volume of the planet
        double volume = ((double)4/3*Math.PI)*(Math.Pow((double)radius ,3));
        double volumeMile = volume * Math.Pow(1.6 , 3);
        
        // Print the result
        Console.WriteLine($"The volume of earth in cubic kilometers is {volume:F2} and cubic miles is {volumeMile:F2}");
    }
}
