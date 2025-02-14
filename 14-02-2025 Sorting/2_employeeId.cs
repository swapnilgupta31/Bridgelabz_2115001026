using System;
class EmployeeID{
    public static void Main(string[] args){
        Console.WriteLine("Enter the number of Employees: ");
        int n  = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the ID's of " + n + " Employees:");
        int[] ID = new int[n];

        for(int i = 0; i < n; i++){
            ID[i] = int.Parse(Console.ReadLine());
        }

        InsertionSort(ID);

        Console.WriteLine("Sorted ID's are:");
        for(int i = 0; i < n; i++){
            Console.Write(ID[i] + " ");
        }
        Console.WriteLine();
    }

    public static void InsertionSort(int[] array){
        int n = array.Length;
        for (int i = 1; i < n; i++){
            int key = array[i]; // Element to be inserted
            int j = i - 1;

            // Shift elements to the right
            while (j >= 0 && array[j] > key){
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key; // Insert at the correct position
        }
    }
}
