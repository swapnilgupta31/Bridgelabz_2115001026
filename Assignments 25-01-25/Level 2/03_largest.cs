using System;

class LargestSecondLargest
{
    public static void Main(string[] args)
    {
        // Take user input for the number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Initialize maxDigit for array size and index variable
        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Store the digits of the number in the array
        while (number != 0)
        {
            digits[index] = number % 10; // Get last digit
            number /= 10; // Remove the last digit from the number
            index++;

            // If we reach the maxDigit, stop adding more digits
            if (index == maxDigit)
            {
                break;
            }
        }

        // Initialize variables to store the largest and second largest
        int largest = -1;
        int secondLargest = -1;

        // Find the largest and second largest digits
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        // Output the largest and second largest digits
        if (largest != -1)
        {
            Console.WriteLine("Largest digit: " + largest);
        }
        else
        {
            Console.WriteLine("No digits found.");
        }

        if (secondLargest != -1)
        {
            Console.WriteLine("Second largest digit: " + secondLargest);
        }
        else
        {
            Console.WriteLine("No second largest digit found.");
        }
    }
}
