using System;

class MultiplicationTable
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a number
        Console.WriteLine("Enter a number to generate its multiplication table:");
        int number = int.Parse(Console.ReadLine());

        // Generate and print the multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
