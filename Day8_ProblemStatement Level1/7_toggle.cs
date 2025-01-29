using System;
class ToggleCase{
    static void Main(string[] args){
        // Take input string
        Console.WriteLine("Enter the string: ");
        string input = Console.ReadLine();

        string result = "";

        // Loop through each character
        for (int i = 0; i < input.Length; i++){
            char c = input[i];

            // Toggle case using ASCII values
            if (c >= 'A' && c <= 'Z'){ // Uppercase to lowercase
                result += (char)(c + 32);
            }else if (c >= 'a' && c <= 'z'){ // Lowercase to uppercase
                result += (char)(c - 32);
            }else{
                result += c; // Keep other characters unchanged
            }
        }

        // Output the toggled string
        Console.WriteLine("Toggled string: " + result);
    }
}