using System;
using System.Linq;

public class NumberChecker{
    public static int[] FindFactors(int number){
        int[] factors = new int[number / 2]; // Only need to check up to half of the number
        int count = 0;
        for (int i = 1; i <= number / 2; i++){
            if (number % i == 0){
                factors[count] = i;
                count++;
            }
        }
        return factors.Take(count).ToArray(); // Return the array of factors with the correct size
    }
    
    public static int FindGreatestFactor(int[] factors){
        return factors.Max();
    }

    public static int FindSumOfFactors(int[] factors){
        return factors.Sum();
    }

    public static int FindProductOfFactors(int[] factors){
        return factors.Aggregate(1, (prod, factor) => prod * factor);
    }

    public static double FindProductOfCubeOfFactors(int[] factors){
        return factors.Aggregate(1.0, (prod, factor) => prod * Math.Pow(factor, 3));
    }

    public static bool IsPerfectNumber(int number){
        int[] factors = FindFactors(number);
        return factors.Sum() == number;
    }

    public static bool IsAbundantNumber(int number){
        int[] factors = FindFactors(number);
        return factors.Sum() > number;
    }

    public static bool IsDeficientNumber(int number){
        int[] factors = FindFactors(number);
        return factors.Sum() < number;
    }

    public static bool IsStrongNumber(int number){
        int[] digits = number.ToString().Select(c => int.Parse(c.ToString())).ToArray();
        int sumOfFactorials = digits.Sum(digit => Factorial(digit));
        return sumOfFactorials == number;
    }

    public static int Factorial(int n){
        if (n == 0) return 1;
        int result = 1;
        for (int i = 1; i <= n; i++){
            result *= i;
        }
        return result;
    }

    public static void Main(string[] args){
        int number = 145; // Example number
        
        // Find factors of the number
        int[] factors = FindFactors(number);
        Console.WriteLine("Factors: " + string.Join(", ", factors));

        // Find the greatest factor
        int greatestFactor = FindGreatestFactor(factors);
        Console.WriteLine("Greatest Factor: " + greatestFactor);

        // Find the sum of the factors
        int sumOfFactors = FindSumOfFactors(factors);
        Console.WriteLine("Sum of Factors: " + sumOfFactors);

        // Find the product of the factors
        int productOfFactors = FindProductOfFactors(factors);
        Console.WriteLine("Product of Factors: " + productOfFactors);

        // Find the product of the cube of the factors
        double productOfCubes = FindProductOfCubeOfFactors(factors);
        Console.WriteLine("Product of Cube of Factors: " + productOfCubes);

        // Check if the number is a perfect number
        bool isPerfect = IsPerfectNumber(number);
        Console.WriteLine("Is Perfect Number: " + isPerfect);

        // Check if the number is an abundant number
        bool isAbundant = IsAbundantNumber(number);
        Console.WriteLine("Is Abundant Number: " + isAbundant);

        // Check if the number is a deficient number
        bool isDeficient = IsDeficientNumber(number);
        Console.WriteLine("Is Deficient Number: " + isDeficient);

        // Check if the number is a strong number
        bool isStrong = IsStrongNumber(number);
        Console.WriteLine("Is Strong Number: " + isStrong);
    }
}
