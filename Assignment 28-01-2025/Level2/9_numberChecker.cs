using System;
public class NumberChecker{
    public string IsPositive(int number){
        if (number >= 0){
            return "positive";
        }
        else{
            return "negative";
        }
    }
    public string IsEven(int number){
        if (number % 2 == 0){
            return "even";
        }
        else{
            return "odd";
        }
    }
    public int CompareNumbers(int num1, int num2){
        if (num1 > num2){
            return 1;
        }
        else if (num1 == num2){
            return 0;
        }
        else{
            return -1;
        }
    }
    public static void Main(string[] args){
        int[] numbers = new int[5];
        NumberChecker checker = new NumberChecker();
        for (int i = 0; i < 5; i++) {
            Console.Write("Enter number " + (i + 1) + ": ");
            numbers[i] = int.Parse(Console.ReadLine());

            string positiveOrNegative = checker.IsPositive(numbers[i]);
            if (positiveOrNegative == "positive"){
                string evenOrOdd = checker.IsEven(numbers[i]);
                Console.WriteLine("Number " + (i + 1) + " is positive and " + evenOrOdd + ".");
            }
            else{
                Console.WriteLine("Number " + (i + 1) + " is negative.");
            }
        }
        int comparisonResult = checker.CompareNumbers(numbers[0], numbers[4]);
        if (comparisonResult == 1){
            Console.WriteLine("First number is greater than the last number.");
        }
        else if (comparisonResult == 0){
            Console.WriteLine("First number is equal to the last number.");
        }
        else{
            Console.WriteLine("First number is less than the last number.");
        }
    }
}