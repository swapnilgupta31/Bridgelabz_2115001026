using System;

class factors
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter a number to find its factors:");
        int number = int.Parse(Console.ReadLine());

        int maxFactor = 10;
        int[] factors = new int[maxFactor]; // Array to store factors
        int index = 0;

        // Loop to find all factors of the number
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (index >= maxFactor)
                {
                    maxFactor *= 2; // Double the array size when it is full
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length); // Copy old factors to new array
                    factors = temp; // Reassign factors array to new larger array
                }

                factors[index] = i; // Store the factor
                index++; // Increment index
            }
        }

        // Concatenate factors into a single string for output
        string result = "Factors of " + number + ": ";
        for (int i = 0; i < index; i++)
        {
            result += factors[i] + " ";
        }

        Console.WriteLine(result); // Output the factors
    }
}
