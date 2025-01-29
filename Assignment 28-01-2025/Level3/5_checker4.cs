using System;
public class NumberChecker{
    public static bool IsPrime(int number){
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++){
            if (number % i == 0) return false;
        }
        return true;
    }
    public static bool IsNeon(int number){
        int square = number * number;
        int sumOfDigits = 0;
        while (square != 0){
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == number;
    }
    public static bool IsSpy(int number){
        int sum = 0, product = 1;
        while (number != 0){
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }
    public static bool IsAutomorphic(int number){
        int square = number * number;
        string numberStr = number.ToString();
        string squareStr = square.ToString();
        return squareStr.EndsWith(numberStr);
    }
    public static bool IsBuzz(int number){
        return number % 7 == 0 || number % 10 == 7;
    }
    public static void Main(string[] args){
        int number = 25; // Example number
        
        // Check if the number is prime
        bool isPrime = IsPrime(number);
        Console.WriteLine("Is Prime: " + isPrime);
        
        // Check if the number is neon
        bool isNeon = IsNeon(number);
        Console.WriteLine("Is Neon: " + isNeon);
        
        // Check if the number is spy
        bool isSpy = IsSpy(number);
        Console.WriteLine("Is Spy: " + isSpy);
        
        // Check if the number is automorphic
        bool isAutomorphic = IsAutomorphic(number);
        Console.WriteLine("Is Automorphic: " + isAutomorphic);
        
        // Check if the number is buzz
        bool isBuzz = IsBuzz(number);
        Console.WriteLine("Is Buzz: " + isBuzz);
    }
}
