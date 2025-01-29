using System;
class CompareStrings{
    static void Main(string[] args){
        // Take input strings
        Console.WriteLine("Enter first string: ");
        string first = Console.ReadLine();

        Console.WriteLine("Enter second string: ");
        string second = Console.ReadLine();

        int minLength = first.Length < second.Length ? first.Length : second.Length;

        // Compare characters one by one
        for (int i = 0; i < minLength; i++){
            if (first[i] < second[i]){
                Console.WriteLine(first + " comes before " + second);
                return;
            }else if (first[i] > second[i]){
                Console.WriteLine(first + " comes after " + second);
                return;
            }
        }
        // If both are same till minLength, check length
        if (first.Length < second.Length){
            Console.WriteLine(first + " comes before " + second);
        }else if (first.Length > second.Length){
            Console.WriteLine(first + " comes after " + second);
        }else{
            Console.WriteLine("Both strings are equal.");
        }
    }
}