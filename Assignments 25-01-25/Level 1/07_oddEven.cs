using System;

class OddEvenNumbers
{
    public static void Main(String[] args)
    {
        // Enter the number and check if it is a natural number
        Console.WriteLine("Enter the number: ");

        int number = int.Parse(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("ERROR!!! Not a Natural Number.");
            return; // Use `return` to exit the program instead of `break`.
        }
        else
        {
            // Create arrays for odd and even numbers
            int[] odd = new int[number / 2 + 1];
            int[] even = new int[number / 2 + 1];

            // Initialize index variables for odd and even numbers
            int oddIndex = 0;
            int evenIndex = 0;

            // Loop through numbers from 1 to the entered number
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    // Add even number to the even array
                    even[evenIndex] = i;
                    evenIndex++;
                }
                else
                {
                    // Add odd number to the odd array
                    odd[oddIndex] = i;
                    oddIndex++;
                }
            }

            // Print the odd numbers
            Console.WriteLine("\nOdd Numbers:");
            for (int i = 0; i < oddIndex; i++)
            {
                Console.Write(odd[i] + " ");
            }

            // Print the even numbers
            Console.WriteLine("\n\nEven Numbers:");
            for (int i = 0; i < evenIndex; i++)
            {
                Console.Write(even[i] + " ");
            }

            Console.WriteLine(); // To add a new line at the end
        }
    }
}
