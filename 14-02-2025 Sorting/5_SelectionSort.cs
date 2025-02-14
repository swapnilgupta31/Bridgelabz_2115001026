using System;

class SelectionSortExample{
    public static void Main(string[] args){
        Console.WriteLine("Enter the number of students:");
        int n = int.Parse(Console.ReadLine());

        int[] scores = new int[n];
        Console.WriteLine("Enter the exam scores:");
        for (int i = 0; i < n; i++){
            scores[i] = int.Parse(Console.ReadLine());
        }

        SelectionSort(scores);

        Console.WriteLine("Sorted exam scores:");
        for (int i = 0; i < n; i++){
            Console.Write(scores[i] + " ");
        }
        Console.WriteLine();
    }

    // Selection Sort Function
    public static void SelectionSort(int[] array){
        int n = array.Length;
        for (int i = 0; i < n - 1; i++){
            int minIndex = i; // Assume the current index has the smallest value

            // Find the minimum element in the remaining array
            for (int j = i + 1; j < n; j++){
                if (array[j] < array[minIndex]){
                    minIndex = j; // Update minIndex if a smaller element is found
                }
            }

            // Swap the found minimum element with the first element of the unsorted part
            Swap(ref array[i], ref array[minIndex]);
        }
    }

    // Swap Function (Using ref to swap values in-place)
    public static void Swap(ref int a, ref int b){
        int temp = a;
        a = b;
        b = temp;
    }
}
