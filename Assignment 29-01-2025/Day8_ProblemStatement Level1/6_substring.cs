using System;
class SubstringOccurrences{
    static void Main(string[] args){
        // Take the input string and substring
        Console.WriteLine("Enter the string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the substring: ");
        string sub = Console.ReadLine();

        int count = 0;
        int subLength = sub.Length;

        // Loop through the input string
        for (int i = 0; i <= input.Length - subLength; i++){
            string compared = "";

            // Compare the substring from the current position
            for (int j = 0; j < subLength; j++){
                compared += input[i + j];
            }

            // If the compared string matches the substring
            if (compared == sub){
                count++;
            }
        }

        Console.WriteLine("Number of Occurrences: " + count);
    }
}
