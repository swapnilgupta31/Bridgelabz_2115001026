using System;
class ReplaceWord{
    static void Main(string[] args){
        // Take input sentence and add space at the end
        Console.WriteLine("Enter the sentence: ");
        string input = Console.ReadLine() + " ";

        // Take words for replacement
        Console.WriteLine("Enter the word to replace: ");
        string oldWord = Console.ReadLine();

        Console.WriteLine("Enter the new word: ");
        string newWord = Console.ReadLine();

        // Call the replace function
        string result = Replace(input, oldWord, newWord);
        Console.WriteLine("Modified Sentence: " + result);
    }

    static string Replace(string input, string oldWord, string newWord){
        string result = "";
        string temp = "";

        for (int i = 0; i < input.Length; i++){
            if (input[i] != ' '){ // Build each word
                temp += input[i];
            }else{
                // Check if temp matches oldWord
                if (temp == oldWord){
                    result += newWord +" ";
                }else{
                    result += temp+ " ";
                }
                temp = ""; // Reset temp for next word
            }
        }
        return result; // Remove extra space from end
    }
}
