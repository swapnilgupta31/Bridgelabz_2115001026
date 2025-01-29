using System;
class AnagramCheck{
    static void Main(string[] args){
        // Take two input strings
        Console.WriteLine("Enter first string: ");
        string first = Console.ReadLine();

        Console.WriteLine("Enter second string: ");
        string second = Console.ReadLine();

        // If lengths are not same, they can't be anagrams
        if (first.Length != second.Length){
            Console.WriteLine("Not Anagrams");
            return;
        }

        int[] count1 = new int[256]; // ASCII size
        int[] count2 = new int[256];

        // Count frequency of each character in both strings
        for (int i = 0; i < first.Length; i++){
            count1[first[i]]++;
            count2[second[i]]++;
        }

        // Compare both frequency arrays
        for (int i = 0; i < 256; i++){
            if (count1[i] != count2[i]){
                Console.WriteLine("Not Anagrams");
                return;
            }
        }

        Console.WriteLine("Anagrams");
    }
}
