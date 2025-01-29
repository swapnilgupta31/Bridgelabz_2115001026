using System;

class Rounds
{
    // Method to calculate the number of rounds required
    static int NumberOfRounds(double side1, double side2, double side3, double distance)
    {
        // Calculate the perimeter of the triangular park
        double perimeter = side1 + side2 + side3;

        // Calculate the number of rounds (using ceiling to ensure next integer)
        double rounds = (distance * 1000) / perimeter;
        return (int)Math.Ceiling(rounds);
    }

    static void Main(string[] args)
    {
        // Take inputs for all three sides of the triangular park
        Console.WriteLine("Enter the sides of the park (in meters):");
        double side1 = double.Parse(Console.ReadLine());
        double side2 = double.Parse(Console.ReadLine());
        double side3 = double.Parse(Console.ReadLine());

        // Take input for the distance the athlete wants to complete (in kilometers)
        Console.WriteLine("Enter the distance the athlete wants to run (in kilometers):");
        double distance = double.Parse(Console.ReadLine());

        // Calculate the number of rounds
        int rounds = NumberOfRounds(side1, side2, side3, distance);

        // Output the result
        Console.WriteLine("Number of rounds the athlete has to complete: " + rounds);
    }
}
