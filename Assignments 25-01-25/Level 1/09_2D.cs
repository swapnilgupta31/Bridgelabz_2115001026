using System;

class MultiDimensionalArray
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows:");
        int rows = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the number of columns:");
        int columns = int.Parse(Console.ReadLine());

        // Create a 2D array (Matrix)
        int[,] matrix = new int[rows, columns];

        // Take user input to populate the 2D array
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write("Enter element at position (" + i + "," + j + "): ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Create a 1D array to store the elements of the 2D array
        int[] array = new int[rows * columns];
        int index = 0;

        // Copy elements of the 2D array into the 1D array
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index] = matrix[i, j]; // Copy element to 1D array
                index++; // Increment the index
            }
        }

        // Display the 1D array
        Console.WriteLine("The 1D array is:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
