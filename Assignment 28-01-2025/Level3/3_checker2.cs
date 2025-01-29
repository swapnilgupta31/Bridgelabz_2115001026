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
    public static int SumOfDigits(int number){
        int[] digits = StoreDigits(number);
        int sum = 0;
        foreach (int digit in digits){
            sum += digit;
        }
        return sum;
    }
    public static double SumOfSquaresOfDigits(int number){
        int[] digits = StoreDigits(number);
        double sumOfSquares = 0;
        foreach (int digit in digits){
            sumOfSquares += Math.Pow(digit, 2);
        }
        return sumOfSquares;
    }
    public static bool IsHarshadNumber(int number){
        int sum = SumOfDigits(number);
        return number % sum == 0;
    }
    public static int[,] FindDigitFrequency(int number){
        int[] digits = StoreDigits(number);
        int[,] frequency = new int[10, 2]; // [digit, frequency]
        
        for (int i = 0; i < 10; i++){
            frequency[i, 0] = i;
        }
        
        foreach (int digit in digits){
            frequency[digit, 1]++;
        }
        
        return frequency;
    }
    public static void Main(string[] args){
        int number = 21; // Example number
        
        // Count the digits
        int digitCount = CountDigits(number);
        Console.WriteLine("Number of digits: " + digitCount);
        
        // Store digits in an array
        int[] digits = StoreDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));
        
        // Sum of digits
        int sumOfDigits = SumOfDigits(number);
        Console.WriteLine("Sum of digits: " + sumOfDigits);
        
        // Sum of squares of digits
        double sumOfSquares = SumOfSquaresOfDigits(number);
        Console.WriteLine("Sum of squares of digits: " + sumOfSquares);
        
        // Check if it's a Harshad number
        bool isHarshad = IsHarshadNumber(number);
        Console.WriteLine("Is Harshad Number: " + isHarshad);
        
        // Find the frequency of each digit
        int[,] frequency = FindDigitFrequency(number);
        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++){
            if (frequency[i, 1] > 0){
                Console.WriteLine("Digit " + frequency[i, 0] + ": " + frequency[i, 1]);
            }
        }
    }
}
