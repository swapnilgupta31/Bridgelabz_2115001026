using System;
public class NumberChecker{
    public static int CountDigits(int number){
        int count = 0;
        while (number != 0){
            number /= 10;
            count++;
        }
        return count;
    }
    public static int[] StoreDigits(int number){
        int count = CountDigits(number);
        int[] digits = new int[count];
        for (int i = count - 1; i >= 0; i--){
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }
    public static int[] ReverseDigits(int[] digits){
        int[] reversed = new int[digits.Length];
        int j = 0;
        for (int i = digits.Length - 1; i >= 0; i--){
            reversed[j++] = digits[i];
        }
        return reversed;
    }
    public static bool AreArraysEqual(int[] array1, int[] array2){
        if (array1.Length != array2.Length) return false;
        for (int i = 0; i < array1.Length; i++){
            if (array1[i] != array2[i]) return false;
        }
        return true;
    }
    public static bool IsPalindrome(int number){
        int[] digits = StoreDigits(number);
        int[] reversedDigits = ReverseDigits(digits);
        return AreArraysEqual(digits, reversedDigits);
    }
    public static bool IsDuckNumber(int number){
        int[] digits = StoreDigits(number);
        foreach (int digit in digits){
            if (digit != 0){
                return true;
            }
        }
        return false;
    }
    public static void Main(string[] args){
        int number = 121; // Example number
        
        // Count the digits
        int digitCount = CountDigits(number);
        Console.WriteLine("Number of digits: " + digitCount);
        
        // Store digits in an array
        int[] digits = StoreDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));
        
        // Reverse the digits array
        int[] reversedDigits = ReverseDigits(digits);
        Console.WriteLine("Reversed Digits: " + string.Join(", ", reversedDigits));
        
        // Check if the number is a palindrome
        bool isPalindrome = IsPalindrome(number);
        Console.WriteLine("Is Palindrome: " + isPalindrome);
        
        // Check if the number is a duck number
        bool isDuckNumber = IsDuckNumber(number);
        Console.WriteLine("Is Duck Number: " + isDuckNumber);
    }
}
