using System;

class CountingSortExample{
    public static void Main(string[] args){
        Console.WriteLine("Enter the number of students:");
        int n = int.Parse(Console.ReadLine());

        int[] ages = new int[n];
        Console.WriteLine("Enter the ages of students (between 10 and 18):");
        for (int i = 0; i < n; i++){
            ages[i] = int.Parse(Console.ReadLine());
        }

        CountingSort(ages);

        Console.WriteLine("Sorted ages in ascending order:");
        for (int i = 0; i < n; i++){
            Console.Write(ages[i] + " ");
        }
        Console.WriteLine();
    }

    // Counting Sort Function
    public static void CountingSort(int[] array){
        int minAge = 10, maxAge = 18; // Given range
        int range = maxAge - minAge + 1;
        int[] count = new int[range]; // Count array
        int[] output = new int[array.Length]; // Output array

        // Step 1: Count the occurrences of each age
        for (int i = 0; i < array.Length; i++){
            count[array[i] - minAge]++;
        }

        // Step 2: Compute cumulative frequency
        for (int i = 1; i < range; i++){
            count[i] += count[i - 1];
        }

        // Step 3: Place elements in sorted order
        for (int i = array.Length - 1; i >= 0; i--){
            output[count[array[i] - minAge] - 1] = array[i];
            count[array[i] - minAge]--;
        }

        // Copy the sorted values back to the original array
        for (int i = 0; i < array.Length; i++){
            array[i] = output[i];
        }
    }
}
