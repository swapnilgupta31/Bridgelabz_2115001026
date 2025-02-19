using System;
using System.Diagnostics;

class SortingComparison {
    static void Main() {
        int size = 10000; // Change this to test different sizes
        int[] data1 = GenerateRandomArray(size);
        int[] data2 = (int[])data1.Clone();
        int[] data3 = (int[])data1.Clone();

        Stopwatch stopwatch = new Stopwatch();

        // Bubble Sort
        stopwatch.Start();
        BubbleSort(data1);
        stopwatch.Stop();
        Console.WriteLine("Bubble Sort Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Merge Sort
        stopwatch.Restart();
        MergeSort(data2, 0, data2.Length - 1);
        stopwatch.Stop();
        Console.WriteLine("Merge Sort Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Quick Sort
        stopwatch.Restart();
        QuickSort(data3, 0, data3.Length - 1);
        stopwatch.Stop();
        Console.WriteLine("Quick Sort Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }

    // Bubble Sort - O(N²)
    static void BubbleSort(int[] arr) {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Merge Sort - O(N log N)
    static void MergeSort(int[] arr, int left, int right) {
        if (left < right) {
            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right) {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        for (int i = 0; i < n1; i++) leftArr[i] = arr[left + i];
        for (int i = 0; i < n2; i++) rightArr[i] = arr[mid + 1 + i];

        int iLeft = 0, iRight = 0, k = left;
        while (iLeft < n1 && iRight < n2) {
            arr[k++] = (leftArr[iLeft] <= rightArr[iRight]) ? leftArr[iLeft++] : rightArr[iRight++];
        }
        while (iLeft < n1) arr[k++] = leftArr[iLeft++];
        while (iRight < n2) arr[k++] = rightArr[iRight++];
    }

    // Quick Sort - O(N log N)
    static void QuickSort(int[] arr, int low, int high) {
        if (low < high) {
            int pivot = Partition(arr, low, high);
            QuickSort(arr, low, pivot - 1);
            QuickSort(arr, pivot + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high) {
        int pivot = arr[high], i = low - 1;
        for (int j = low; j < high; j++) {
            if (arr[j] < pivot) {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;
        return i + 1;
    }

    // Helper Method: Generates an array with random values
    static int[] GenerateRandomArray(int size) {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++) {
            arr[i] = rand.Next(1, 100000);
        }
        return arr;
    }
}
