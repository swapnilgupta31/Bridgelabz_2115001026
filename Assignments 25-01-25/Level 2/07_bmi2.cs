using System;

class BMI_Calculator
{
    public static void Main(string[] args)
    {
        // Take input for number of persons
        Console.WriteLine("Enter the number of persons:");
        int numPersons = int.Parse(Console.ReadLine());

        // Create a multi-dimensional array to store height, weight, and BMI
        double[][] personData = new double[numPersons][3];
        string[] weightStatus = new string[numPersons];

        // Input weight and height for each person, and calculate BMI
        for (int i = 0; i < numPersons; i++)
        {
            double height, weight;

            // Get height and weight for the person, and validate positive values
            do
            {
                Console.WriteLine("Enter height (in meters) for person " + (i + 1) + ":");
                height = double.Parse(Console.ReadLine());
                if (height <= 0)
                    Console.WriteLine("Height should be a positive value. Please enter again.");
            } while (height <= 0);

            do
            {
                Console.WriteLine("Enter weight (in kg) for person " + (i + 1) + ":");
                weight = double.Parse(Console.ReadLine());
                if (weight <= 0)
                    Console.WriteLine("Weight should be a positive value. Please enter again.");
            } while (weight <= 0);

            // Store height and weight in the personData array
            personData[i][0] = height;
            personData[i][1] = weight;

            // Calculate BMI and store it in the third column of the array
            double bmi = weight / (height * height);
            personData[i][2] = bmi;

            // Determine weight status based on BMI
            if (bmi < 18.5)
                weightStatus[i] = "Underweight";
            else if (bmi < 24.9)
                weightStatus[i] = "Normal weight";
            else if (bmi < 29.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        // Display height, weight, BMI, and status for each person
        Console.WriteLine("\nSummary of BMI and weight status for each person:");

        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine("Person " + (i + 1) + ":");
            Console.WriteLine("Height: " + personData[i][0] + " meters");
            Console.WriteLine("Weight: " + personData[i][1] + " kg");
            Console.WriteLine("BMI: " + personData[i][2].ToString("0.00"));
            Console.WriteLine("Status: " + weightStatus[i]);
            Console.WriteLine();
        }
    }
}
