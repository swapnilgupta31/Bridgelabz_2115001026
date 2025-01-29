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
    public static bool IsDuckNumber(int number){
        int[] digits = StoreDigits(number);
        foreach (int digit in digits){
            if (digit != 0){
                return true;
            }
        }
        return false;
    }
    public static bool IsArmstrongNumber(int number){
        int[] digits = StoreDigits(number);
        int sum = 0;
        int count = digits.Length;
        foreach (int digit in digits){
            sum += (int)Math.Pow(digit, count);
        }
        return sum == number;
    }
    public static (int, int) FindLargestAndSecondLargest(int[] digits){
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;
        foreach (int digit in digits){
            if (digit > largest){
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest){
                secondLargest = digit;
            }
        }
        return (largest, secondLargest);
    }
    public static (int, int) FindSmallestAndSecondSmallest(int[] digits){
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;
        foreach (int digit in digits){
            if (digit < smallest){
                secondSmallest = smallest;
                smallest = digit;
            }
            else if (digit < secondSmallest && digit != smallest){
                secondSmallest = digit;
            }
        }
        return (smallest, secondSmallest);
    }
    public static void Main(string[] args){
        int number = 153; // Example number
        
        // Find the count of digits
        int digitCount = CountDigits(number);
        Console.WriteLine("Number of digits: " + digitCount);
        
        // Store digits in an array
        int[] digits = StoreDigits(number);
        Console.WriteLine("Digits: " + string.Join(", ", digits));
        
        // Check if it's a duck number
        bool isDuck = IsDuckNumber(number);
        Console.WriteLine("Is Duck Number: " + isDuck);
        
        // Check if it's an Armstrong number
        bool isArmstrong = IsArmstrongNumber(number);
        Console.WriteLine("Is Armstrong Number: " + isArmstrong);
        
        // Find largest and second largest digits
        var (largest, secondLargest) = FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest: " + largest + ", Second Largest: " + secondLargest);
        
        // Find smallest and second smallest digits
        var (smallest, secondSmallest) = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest: " + smallest + ", Second Smallest: " + secondSmallest);
    }
}
