using System;

class BMIProgram
{
    static void Main(string[] args)
    {
        // Prompt the user to input weight in kilograms
        Console.WriteLine("Enter your weight in kilograms (kg):");
        double weight = double.Parse(Console.ReadLine());

        // Prompt the user to input height in centimeters
        Console.WriteLine("Enter your height in centimeters (cm):");
        double heightCm = double.Parse(Console.ReadLine());

        // Convert height from cm to meters
        double heightMeters = heightCm / 100;

        // Calculate BMI
        double bmi = weight / (heightMeters * heightMeters);

        // Display the BMI value
        Console.WriteLine($"Your BMI is: {bmi:F2}");

        // Determine weight status based on BMI
        if (bmi <= 18.4)
        {
            Console.WriteLine("Weight Status: Underweight");
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Weight Status: Normal");
        }
        else if (bmi >= 25.0 && bmi <= 39.9)
        {
            Console.WriteLine("Weight Status: Overweight");
        }
        else if (bmi >= 40.0)
        {
            Console.WriteLine("Weight Status: Obese");
        }
    }
}
