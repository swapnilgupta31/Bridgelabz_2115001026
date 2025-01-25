using System;

class DigitFrequency
{
    static void Main(string[] args)
    {
        // Input the number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Convert the number to string to easily access individual digits
        string numString = number.ToString();

        // Create an array to store the frequency of digits (0-9)
        int[] frequency = new int[10];

        // Loop through each digit in the number and count the frequency
        foreach (char digitChar in numString)
        {
            int digit = digitChar - '0'; // Convert char to integer
            frequency[digit]++; // Increment the frequency of the corresponding digit
        }

        // Display the frequency of each digit
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine($"Digit {i}: {frequency[i]} times");
            }
        }
    }
}
