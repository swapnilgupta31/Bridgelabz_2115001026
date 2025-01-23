using System;

class DivisibilityChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a number:");

        // Get input value for the number
        int number = int.Parse(Console.ReadLine());

        // Check if natural 
        if (number >= 0)
        {
			int sum = number*(number+1)/2;
            Console.WriteLine("The sum of " + number + " natural numbers is " + sum);
        }
        else
        {
            Console.WriteLine("The number " + number +" is not a natural number");
        }
    }
}
