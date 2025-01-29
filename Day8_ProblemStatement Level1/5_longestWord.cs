using System;
class LongestWord{
    static void Main(string[] args){
        // Take input sentence from user
        Console.WriteLine("Enter a sentence: ");
        string sentence = Console.ReadLine();

        // Initialize variables to store the longest word and current word
        string longestWord = "";
        string currentWord = "";

        // Loop through each character in the sentence
        for (int i = 0; i < sentence.Length; i++){
            // If the character is a space, check if current word is the longest
            if (sentence[i] == ' '){
                if (currentWord.Length > longestWord.Length){
                    longestWord = currentWord;
                }
                currentWord = ""; // Reset the current word
            }
            else{
                currentWord += sentence[i]; // Add character to current word
            }
        }

        // Final check for the last word in the sentence
        if (currentWord.Length > longestWord.Length){
            longestWord = currentWord;
        }

        // Output the longest word
        Console.WriteLine("The longest word is: " + longestWord);
    }
}
