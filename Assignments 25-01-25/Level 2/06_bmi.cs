using System;

class BMI_Calculator
{
    public static void Main(string[] args)
    {
        // Take input for number of persons
        Console.WriteLine("Enter the number of persons:");
        int numPersons = int.Parse(Console.ReadLine());

        // Create arrays to store height, weight, BMI, and weight status
        double[] height = new double[numPersons];
        double[] weight = new double[numPersons];
        double[] bmi = new double[numPersons];
        string[] status = new string[numPersons];

        // Input weight and height for each person and calculate BMI
        for (int i = 0; i < numPersons; i++)
        {
            // Get height and weight for the person
            Console.WriteLine("Enter height (in meters) for person " + (i + 1) + ":");
            height[i] = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter weight (in kg) for person " + (i + 1) + ":");
            weight[i] = double.Parse(Console.ReadLine());

            // Calculate BMI
            bmi[i] = weight[i] / (height[i] * height[i]);

            // Determine weight status based on BMI
            if (bmi[i] < 18.5)
                status[i] = "Underweight";
            else if (bmi[i] < 24.9)
                status[i] = "Normal weight";
            else if (bmi[i] < 29.9)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }

        // Display height, weight, BMI, and status for each person
        Console.WriteLine("\nSummary of BMI and weight status for each person:");

        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ":");
            Console.WriteLine("Height: " + height[i] + " meters");
            Console.WriteLine("Weight: " + weight[i] + " kg");
            Console.WriteLine("BMI: " + bmi[i].ToString("0.00"));
            Console.WriteLine("Status: " + status[i]);
            Console.WriteLine();
        }
    }
}
