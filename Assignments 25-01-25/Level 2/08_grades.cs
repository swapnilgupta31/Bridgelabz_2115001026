using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        // Input the number of students
        Console.WriteLine("Enter the number of students:");
        int numStudents = int.Parse(Console.ReadLine());

        // Arrays to store marks, percentages, and grades
        int[] physicsMarks = new int[numStudents];
        int[] chemistryMarks = new int[numStudents];
        int[] mathsMarks = new int[numStudents];
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];
        string[] levels = new string[numStudents];

        // Take input for marks for each student
        for (int i = 0; i < numStudents; i++)
        {
            int physics, chemistry, maths;

            // Input validation to ensure marks are between 0 and 100
            do
            {
                Console.WriteLine($"Enter Physics marks for student {i + 1} (0-100):");
                physics = int.Parse(Console.ReadLine());
                if (physics < 0 || physics > 100)
                    Console.WriteLine("Invalid input! Marks should be between 0 and 100.");
            } while (physics < 0 || physics > 100);

            do
            {
                Console.WriteLine($"Enter Chemistry marks for student {i + 1} (0-100):");
                chemistry = int.Parse(Console.ReadLine());
                if (chemistry < 0 || chemistry > 100)
                    Console.WriteLine("Invalid input! Marks should be between 0 and 100.");
            } while (chemistry < 0 || chemistry > 100);

            do
            {
                Console.WriteLine($"Enter Maths marks for student {i + 1} (0-100):");
                maths = int.Parse(Console.ReadLine());
                if (maths < 0 || maths > 100)
                    Console.WriteLine("Invalid input! Marks should be between 0 and 100.");
            } while (maths < 0 || maths > 100);

            // Store marks in respective arrays
            physicsMarks[i] = physics;
            chemistryMarks[i] = chemistry;
            mathsMarks[i] = maths;

            // Calculate total marks and percentage
            int totalMarks = physics + chemistry + maths;
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
            Console.WriteLine($"Physics Marks: {physicsMarks[i]}, Chemistry Marks: {chemistryMarks[i]}, Maths Marks: {mathsMarks[i]}");
            Console.WriteLine($"Percentage: {percentages[i]:0.00}%");
            Console.WriteLine($"Grade: {grades[i]}");
            Console.WriteLine($"Level: {levels[i]}\n");
        }
    }
}
