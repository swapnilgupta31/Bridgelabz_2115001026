using System;
class MostFrequentChar{
    static void Main(string[] args){
        // Take input string
        Console.WriteLine("Enter the string: ");
        string input = Console.ReadLine();

        int maxCount = 0;
        char mostFrequent = ' ';

        // Loop through each character
        for (int i = 0; i < input.Length; i++){
            char current = input[i];
            int count = 0;
            
            // Count occurrences of current character
            for (int j = 0; j < input.Length; j++){
                if (input[j] == current){
                    count++;
                }
            }
            // Update most frequent character if new max found
            if (count > maxCount){
                maxCount = count;
                mostFrequent = current;
            }
        }
        Console.WriteLine("Most Frequent Character: " + mostFrequent);
    }
}
