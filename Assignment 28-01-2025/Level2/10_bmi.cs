using System;
public class BMI_Calculator{
    public double CalculateBMI(double weight, double height){
        height = height / 100;  // Convert height from cm to meters
        return weight / (height * height);
    }
    public string[] GetBMIStatus(double[] bmiValues){
        string[] statuses = new string[10];
        for (int i = 0; i < bmiValues.Length; i++){
            if (bmiValues[i] < 18.5){
                statuses[i] = "Underweight";
            }
            else if (bmiValues[i] >= 18.5 && bmiValues[i] <= 24.9){
                statuses[i] = "Normal weight";
            }
            else if (bmiValues[i] >= 25 && bmiValues[i] <= 29.9){
                statuses[i] = "Overweight";
            }
            else{
                statuses[i] = "Obese";
            }
        }
        return statuses;
    }
    public static void Main(string[] args){
        double[,] data = new double[10, 3]; // 10 people, 3 columns (weight, height, bmi)
        double[] bmiValues = new double[10];
        string[] bmiStatus = new string[10];
        BMI_Calculator calculator = new BMI_Calculator();
        // Input for weight and height
        for (int i = 0; i < 10; i++){
            Console.Write("Enter weight (kg) for person " + (i + 1) + ": ");
            data[i, 0] = double.Parse(Console.ReadLine());
            Console.Write("Enter height (cm) for person " + (i + 1) + ": ");
            data[i, 1] = double.Parse(Console.ReadLine());

            // Calculate BMI
            bmiValues[i] = calculator.CalculateBMI(data[i, 0], data[i, 1]);
            data[i, 2] = bmiValues[i]; // Store BMI in the third column
        }
        // Get BMI status for each person
        bmiStatus = calculator.GetBMIStatus(bmiValues);

        // Output the results
        for (int i = 0; i < 10; i++){
            Console.WriteLine("Person " + (i + 1) + " - Weight: " + data[i, 0] + " kg, Height: " + data[i, 1] + " cm, BMI: " + data[i, 2] + ", Status: " + bmiStatus[i]);
        }
    }
}
