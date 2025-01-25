using System;

class ReverseNumber
{
    public static void Main(string[] args)
    {
        // Take user input for the number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Find the count of digits in the number
        int temp = number;
        int digitCount = 0;
        
        // Count the number of digits
        while (temp != 0)
        {
            temp /= 10;
            digitCount++;
        }

        // Create an array to store the digits of the number
        int[] digits = new int[digitCount];
        int index = 0;

        // Store the digits in the array
        temp = number;
        while (temp != 0)
        {
            digits[index] = temp % 10;
            temp /= 10;
            index++;
        }

        // Display the digits in reverse order
        Console.Write("Reversed number: ");
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}
