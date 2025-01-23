using System;

class DivisibilityChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter the number :");

        // Get input value 
        int number = int.Parse(Console.ReadLine());

        // Check if a person can vote 
        if (number > 0)
        {
            Console.WriteLine("positive");
        }
        else if(number < 0 )
        {
            Console.WriteLine("negative");

        }
        else{
            Console.WriteLine("Zero");
        }
    }
}
