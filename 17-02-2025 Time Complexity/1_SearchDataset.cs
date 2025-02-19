using System;
using System.Diagnostics;

class SearchComparison {
    static void Main() {
        int[] data = GenerateSortedArray(1000000); // Sorted array for Binary Search
        int target = data[data.Length - 1]; // Target at the last index for worst case

        // Measure Linear Search Time
        Stopwatch stopwatch = Stopwatch.StartNew();
        int linearIndex = LinearSearch(data, target);
        stopwatch.Stop();
        Console.WriteLine("Linear Search Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Binary Search Time
        stopwatch.Restart();
        int binaryIndex = BinarySearch(data, target);
        stopwatch.Stop();
        Console.WriteLine("Binary Search Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }

    // Linear Search - O(N)
    static int LinearSearch(int[] arr, int target) {
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == target) {
                return i;
            }
        }
        return -1;
    }

    // Binary Search - O(log N)
    static int BinarySearch(int[] arr, int target) {
        int left = 0, right = arr.Length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target) return mid;
            if (arr[mid] < target) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }

    // Helper Method: Generates a sorted array from 1 to N
    static int[] GenerateSortedArray(int size) {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = i + 1;
        }
        return arr;
    }
}
