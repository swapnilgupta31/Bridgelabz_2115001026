using System;
class RemoveDuplicates{
    static void Main(string[] args){
        // Take input string from user
        Console.WriteLine("Enter the input String: ");
        string input = Console.ReadLine();
        // Initiate the empty output string
        string output = "";
        for(int i = 0; i < input.Length; i++){
            // Check if the character is already in the output string
            bool isDuplicate = false;
            for(int j = 0; j < output.Length; j++){
                if(input[i] == output[j]){
                    isDuplicate = true;
                    break;
                }
            }
            // If it's not a duplicate, add it to the output string
            if(!isDuplicate){
                output += input[i];
            }
        }
        // Print the modified string
        Console.WriteLine("The modified string is: " + output);
    }
}
