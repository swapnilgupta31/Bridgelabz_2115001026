using System;

class SmallestAndLargest
{
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        // Initialize smallest and largest variables
        int smallest = number1;
        int largest = number1;

        // Compare number2 with current smallest and largest
        if (number2 < smallest)
        {
            smallest = number2;
        }
        if (number2 > largest)
        {
            largest = number2;
        }

        // Compare number3 with current smallest and largest
        if (number3 < smallest)
        {
            smallest = number3;
        }
        if (number3 > largest)
        {
            largest = number3;
        }

        // Return both smallest and largest as an array
        return new int[] { smallest, largest };
    }

    static void Main(string[] args)
    {
        // Take user input for three numbers
        Console.WriteLine("Enter the first number:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        int number3 = int.Parse(Console.ReadLine());

        // Call the method to find smallest and largest
        int[] result = FindSmallestAndLargest(number1, number2, number3);

        // Display the result
        Console.WriteLine("The smallest number is: " + result[0]);
        Console.WriteLine("The largest number is: " + result[1]);
    }
}
