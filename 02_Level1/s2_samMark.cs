using System;

public class samMark
{
    // Entry point of the program
    public static void Main(string[] args)
    {
        // Marks obtained in each subject
        int mathsMark = 94;
        int physicsMark = 95;
        int chemistryMark = 96;

        // Total marks possible for each subject
        int totalMarks = 100;

        // Calculate the average percentage
        double averagePercent = (mathsMark + physicsMark + chemistryMark) / 3.0;

        // Output the average percentage
        Console.WriteLine("Sams average mark in PCM is " + averagePercent + "%");
    }
}
