using System;
class PalindromeChecker{
    static void Main(){
        // Get the input string
        string input = GetInput();

        // Check if the string is a palindrome
        bool isPalindrome = CheckPalindrome(input);

        // Display the result
        DisplayResult(isPalindrome);
    }
    // Function to get user input
    static string GetInput(){
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }
    // Function to check if the string is a palindrome
    static bool CheckPalindrome(string input){
        // Remove spaces and convert to lowercase for comparison
        string cleanedInput = input.Replace(" ", "").ToLower();

        // Check if the string equals its reverse
        char[] inputArray = cleanedInput.ToCharArray();
        Array.Reverse(inputArray);
        string reversedInput = new string(inputArray);

        return cleanedInput == reversedInput;
    }
    // Function to display the result
    static void DisplayResult(bool isPalindrome){
        if (isPalindrome)
            Console.WriteLine("The string is a palindrome.");
        else
            Console.WriteLine("The string is not a palindrome.");
    }
}
