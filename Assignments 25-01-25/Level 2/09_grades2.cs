using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        // Input the number of students
        Console.WriteLine("Enter the number of students:");
        int numStudents = int.Parse(Console.ReadLine());

        // 2D array to store marks for Physics, Chemistry, and Maths (3 subjects)
        int[,] marks = new int[numStudents, 3];
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];
        string[] levels = new string[numStudents];

        // Take input for marks for each student
        for (int i = 0; i < numStudents; i++)
        {
            // Input validation to ensure marks are between 0 and 100
            for (int j = 0; j < 3; j++) // Loop through the 3 subjects: Physics, Chemistry, Maths
            {
                string subject = j == 0 ? "Physics" : (j == 1 ? "Chemistry" : "Maths");
                int subjectMarks;
                do
                {
                    Console.WriteLine($"Enter {subject} marks for student {i + 1} (0-100):");
                    subjectMarks = int.Parse(Console.ReadLine());
                    if (subjectMarks < 0 || subjectMarks > 100)
                        Console.WriteLine("Invalid input! Marks should be between 0 and 100.");
                } while (subjectMarks < 0 || subjectMarks > 100);

                marks[i, j] = subjectMarks; // Store marks in the 2D array
            }

            // Calculate total marks and percentage
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            double percentage = (totalMarks / 3.0);
            percentages[i] = percentage;

            // Assign grade and level based on percentage
            if (percentage >= 80)
            {
                grades[i] = "A";
                levels[i] = "Level 4";
            }
            else if (percentage >= 70)
            {
                grades[i] = "B";
                levels[i] = "Level 3";
            }
            else if (percentage >= 60)
            {
                grades[i] = "C";
                levels[i] = "Level 2";
            }
            else if (percentage >= 50)
            {
                grades[i] = "D";
                levels[i] = "Level 1";
            }
            else if (percentage >= 40)
            {
                grades[i] = "E";
                levels[i] = "Level 1-";
            }
            else
            {
                grades[i] = "R";
                levels[i] = "Remedial Standards";
            }
        }

        // Output results for each student
        Console.WriteLine("\nResults:");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Student {i + 1}:");
            Console.WriteLine($"Physics Marks: {marks[i, 0]}, Chemistry Marks: {marks[i, 1]}, Maths Marks: {marks[i, 2]}");
            Console.WriteLine($"Percentage: {percentages[i]:0.00}%");
            Console.WriteLine($"Grade: {grades[i]}");
            Console.WriteLine($"Level: {levels[i]}\n");
        }
    }
}
