using System;
class BookStore{
    public static void Main(string[] args){
        Console.WriteLine("Enter the number of book prices: ");
        int n = int.Parse(Console.ReadLine());

        int[] prices = new int[n];
        Console.WriteLine("Enter the book prices:");
        for(int i = 0; i < n; i++){
            prices[i] = int.Parse(Console.ReadLine());
        }
        MergeSort(prices, 0, n - 1);

        Console.WriteLine("Sorted book prices:");
        for(int i = 0; i < n; i++){
            Console.Write(prices[i] + " ");
        }
        Console.WriteLine();
    }
    // Merge Sort function
    public static void MergeSort(int[] array, int left, int right){
        if (left < right){
            int mid = (left + right) / 2;

            MergeSort(array, left, mid);   // Sort first half
            MergeSort(array, mid + 1, right); // Sort second half
            Merge(array, left, mid, right);  // Merge the sorted halves
        }
    }
    // Merge function to combine two sorted subarrays
    public static void Merge(int[] array, int left, int mid, int right){
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = array[mid + 1 + j];

        int i1 = 0, i2 = 0, k = left;

        // Merge the two sorted arrays
        while (i1 < n1 && i2 < n2){
            if (leftArray[i1] <= rightArray[i2]){
                array[k] = leftArray[i1];
                i1++;
            } else {
                array[k] = rightArray[i2];
                i2++;
            }
            k++;
        }
        // Copy remaining elements
        while (i1 < n1){
            array[k] = leftArray[i1];
            i1++;
            k++;
        }
        while (i2 < n2){
            array[k] = rightArray[i2];
            i2++;
            k++;
        }
    }
}
