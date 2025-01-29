using System;

public class StudentMarks
{
    public int[,] GenerateRandomScores(int numberOfStudents)
    {
        Random random = new Random();
        int[,] scores = new int[numberOfStudents, 3];
        for (int i = 0; i < numberOfStudents; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                scores[i, j] = random.Next(50, 101);  // Random scores between 50 and 100
            }
        }
        return scores;
    }

    public double[,] CalculateResults(int[,] scores, int numberOfStudents)
    {
        double[,] results = new double[numberOfStudents, 3];
        for (int i = 0; i < numberOfStudents; i++)
        {
            int total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = Math.Round(total / 3.0, 2);
            double percentage = Math.Round((total / 300.0) * 100, 2);
            results[i, 0] = total;
            results[i, 1] = average;
            results[i, 2] = percentage;
        }
        return results;
    }

    public void DisplayResults(int[,] scores, double[,] results, int numberOfStudents)
    {
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine((i + 1) + "\t" + scores[i, 0] + "\t\t" + scores[i, 1] + "\t\t" + scores[i, 2] + "\t" + results[i, 0] + "\t" + results[i, 1] + "\t" + results[i, 2]);
        }
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        StudentMarks studentMarks = new StudentMarks();

        // Generate random scores
        int[,] scores = studentMarks.GenerateRandomScores(numberOfStudents);

        // Calculate total, average, and percentage
        double[,] results = studentMarks.CalculateResults(scores, numberOfStudents);

        // Display results in tabular format
        studentMarks.DisplayResults(scores, results, numberOfStudents);
    }
}
