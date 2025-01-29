using System;
public class RandomValues{
    public int[] Generate4DigitRandomArray(int size){
        Random rand = new Random();
        int[] randomNumbers = new int[size];
        for (int i = 0; i < size; i++){
            randomNumbers[i] = rand.Next(1000, 10000); // Generate random 4-digit number
        }
        return randomNumbers;
    }
    public double[] FindAverageMinMax(int[] numbers){
        double average = 0;
        int min = numbers[0];
        int max = numbers[0];
        for (int i = 0; i < numbers.Length; i++){
            average += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }
        average /= numbers.Length;
        return new double[] { average, min, max };
    }
    public static void Main(string[] args){
        RandomValues randomValues = new RandomValues();
        int size = 5;
        // Generate 5 random 4-digit numbers
        int[] numbers = randomValues.Generate4DigitRandomArray(size);
        // Find the average, min, and max values
        double[] results = randomValues.FindAverageMinMax(numbers);
        // Output the results
        Console.WriteLine("Generated Numbers: ");
        for (int i = 0; i < size; i++){
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Average: " + results[0]);
        Console.WriteLine("Minimum: " + results[1]);
        Console.WriteLine("Maximum: " + results[2]);
    }
}
