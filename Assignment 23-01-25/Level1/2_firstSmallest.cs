using System;

class firstSamllest
{
    static void Main(string[] args)
    {
        // Prompt the user for input
        Console.WriteLine("Enter a numbers:");

        // Get input value for the number
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());


        // Check divisibility and display the result
        if (number1 <= number2 && number1 <= number3)
        {
            Console.WriteLine(" Is the first number the smallest? Yes");
        }
        else
        {
            Console.WriteLine("Is the first number the smallest? No");
        }
    }
}
