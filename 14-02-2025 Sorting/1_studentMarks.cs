using System;

class Program{
    public static void Main(){
        Console.WriteLine("Enter the number of Students: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter marks of " + n + " students:");
        int[] marks = new int[n];

        for (int i = 0; i < n; i++){
            marks[i] = int.Parse(Console.ReadLine());
        }

        SortArray(marks);

        Console.Write("Sorted array is: ");
        foreach (int mark in marks){
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }

    public static void SortArray(int[] array){
        for (int i = 0; i < array.Length - 1; i++){
            for (int j = 0; j < array.Length - i - 1; j++){
                if (array[j] > array[j + 1]){
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }

    public static void Swap(ref int a, ref int b){
        int temp = a;
        a = b;
        b = temp;
    }
}
