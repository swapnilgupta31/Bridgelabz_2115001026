using System;
class RemoveChar{
    static void Main(string[] args){
        // Take input string
        Console.WriteLine("Enter the string: ");
        string input = Console.ReadLine();

        // Take character to remove
        Console.WriteLine("Enter the character to remove: ");
        char ch = Console.ReadLine()[0];

        string result = "";

        // Loop through the string and add only non-matching characters
        for (int i = 0; i < input.Length; i++){
            if (input[i] != ch){
                result += input[i];
            }
        }

        Console.WriteLine("Modified String: " + result);
    }
}
