using System;

class YoungestTallestFriends
{
    public static void Main(String[] args)
    {
        // Declare arrays to store ages and heights
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Input the ages and heights of the three friends
        Console.WriteLine("Enter the age and height of Amar:");
        ages[0] = int.Parse(Console.ReadLine());
        heights[0] = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the age and height of Akbar:");
        ages[1] = int.Parse(Console.ReadLine());
        heights[1] = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the age and height of Anthony:");
        ages[2] = int.Parse(Console.ReadLine());
        heights[2] = double.Parse(Console.ReadLine());

        // Find the youngest friend
        int youngestAge = ages[0];
        int youngestIndex = 0;

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < youngestAge)
            {
                youngestAge = ages[i];
                youngestIndex = i;
            }
        }

        // Find the tallest friend
        double tallestHeight = heights[0];
        int tallestIndex = 0;

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > tallestHeight)
            {
                tallestHeight = heights[i];
                tallestIndex = i;
            }
        }

        // Output the results
        string[] names = { "Amar", "Akbar", "Anthony" };
        Console.WriteLine("The youngest friend is: " + names[youngestIndex] + " with age " + youngestAge);
        Console.WriteLine("The tallest friend is: " + names[tallestIndex] + " with height " + tallestHeight);
    }
}
