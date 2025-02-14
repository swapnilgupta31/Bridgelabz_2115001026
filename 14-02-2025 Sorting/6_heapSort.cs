using System;

class HeapSortExample{
    public static void Main(string[] args){
        Console.WriteLine("Enter the number of job applicants:");
        int n = int.Parse(Console.ReadLine());

        int[] salaries = new int[n];
        Console.WriteLine("Enter the expected salaries:");
        for (int i = 0; i < n; i++){
            salaries[i] = int.Parse(Console.ReadLine());
        }

        HeapSort(salaries);

        Console.WriteLine("Sorted salaries in ascending order:");
        for (int i = 0; i < n; i++){
            Console.Write(salaries[i] + " ");
        }
        Console.WriteLine();
    }

    // Heap Sort Function
    public static void HeapSort(int[] array){
        int n = array.Length;

        // Step 1: Build a Max Heap
        for (int i = n / 2 - 1; i >= 0; i--){
            Heapify(array, n, i);
        }

        // Step 2: Extract elements from heap one by one
        for (int i = n - 1; i > 0; i--){
            Swap(ref array[0], ref array[i]); // Move root (max element) to end
            Heapify(array, i, 0); // Heapify the reduced heap
        }
    }

    // Heapify function to maintain max heap property
    public static void Heapify(int[] array, int n, int i){
        int largest = i; // Assume current node is largest
        int left = 2 * i + 1; // Left child index
        int right = 2 * i + 2; // Right child index

        // Check if left child is larger than root
        if (left < n && array[left] > array[largest]){
            largest = left;
        }

        // Check if right child is larger than largest so far
        if (right < n && array[right] > array[largest]){
            largest = right;
        }

        // If largest is not root, swap and recursively heapify the affected subtree
        if (largest != i){
            Swap(ref array[i], ref array[largest]);
            Heapify(array, n, largest);
        }
    }

    // Swap Function (Using ref to swap values in-place)
    public static void Swap(ref int a, ref int b){
        int temp = a;
        a = b;
        b = temp;
    }
}
