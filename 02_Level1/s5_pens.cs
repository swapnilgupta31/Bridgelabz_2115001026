using System;

public class pens
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Take pens as input
        Console.WriteLine("Enter the number of pens: ");
        int pens = int.Parse(Console.ReadLine());

        // Take students as input
        Console.WriteLine("Enter the number of students: ");
        int students = int.Parse(Console.ReadLine());

        // Calculate undistrbuted pens
        int pensLeft = pens%students;

        // Calculate distributed pens
        int pensDistributed = pens / students ;

        // Print the result
        Console.WriteLine($"The Pen Per Student is {pensDistributed} and the remaining pen not distributed is {pensLeft}");
    }
}
