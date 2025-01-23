using System;

class DivisibilityChecker
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter your age");

        // Get input value for the age
        int age = int.Parse(Console.ReadLine());

        // Check if a person can vote 
        if (age >= 18)
        {
            Console.WriteLine("The person's age is " + age + " and can vote");
        }
        else
        {
            Console.WriteLine("The person's age is " + age + " and cannot vote");
        }
    }
}
