using System;
class QuickSortExample{
    public static void Main(string[] args){
        Console.WriteLine("Enter the number of product prices: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];
        Console.WriteLine("Enter the product prices:");
        for (int i = 0; i < n; i++){
            prices[i] = int.Parse(Console.ReadLine());
        }

        QuickSort(prices, 0, n - 1);

        Console.WriteLine("Sorted product prices:");
        for (int i = 0; i < n; i++){
            Console.Write(prices[i] + " ");
        }
        Console.WriteLine();
    }

    // QuickSort Function
    public static void QuickSort(int[] array, int low, int high){
        if (low < high){
            int pivotIndex = Partition(array, low, high);

            QuickSort(array, low, pivotIndex - 1);  // Sort left part
            QuickSort(array, pivotIndex + 1, high); // Sort right part
        }
    }

    // Partition Function
    public static int Partition(int[] array, int low, int high){
        int pivot = array[high]; // Choosing last element as pivot
        int i = low - 1; // Pointer for smaller element

        for (int j = low; j < high; j++){
            if (array[j] < pivot){  // If current element is smaller than pivot
                i++;
                Swap(ref array[i], ref array[j]); // Swap elements
            }
        }
        Swap(ref array[i + 1], ref array[high]); // Place pivot in correct position
        return i + 1; // Return pivot index
    }

    // Swap Function (Using ref to swap in-place)
    public static void Swap(ref int a, ref int b){
        int temp = a;
        a = b;
        b = temp;
    }
}
