using System;

class YoungestAndTallest
{
    static void Main(string[] args)
    {
        // Input ages of Amar, Akbar, and Anthony
        Console.WriteLine("Enter the age of Amar:");
        int ageAmar = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the age of Akbar:");
        int ageAkbar = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the age of Anthony:");
        int ageAnthony = int.Parse(Console.ReadLine());

        // Input heights of Amar, Akbar, and Anthony
        Console.WriteLine("Enter the height of Amar (in cm):");
        double heightAmar = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of Akbar (in cm):");
        double heightAkbar = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the height of Anthony (in cm):");
        double heightAnthony = double.Parse(Console.ReadLine());

        // Find the youngest friend based on age
        int youngestAge = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
        string youngestFriend = (youngestAge == ageAmar) ? "Amar" :
                                (youngestAge == ageAkbar) ? "Akbar" : "Anthony";

        // Find the tallest friend based on height
        double tallestHeight = Math.Max(heightAmar, Math.Max(heightAkbar, heightAnthony));
        string tallestFriend = (tallestHeight == heightAmar) ? "Amar" :
                               (tallestHeight == heightAkbar) ? "Akbar" : "Anthony";

        // Display results
        Console.WriteLine($"The youngest friend is {youngestFriend} with an age of {youngestAge} years.");
        Console.WriteLine($"The tallest friend is {tallestFriend} with a height of {tallestHeight} cm.");
    }
}
