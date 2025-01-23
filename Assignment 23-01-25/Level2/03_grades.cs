using System;

class GradeCalculator
{
    static void Main(string[] args)
    {
        // Input marks for Physics
        Console.WriteLine("Enter marks for Physics (0-100):");
        int physics = int.Parse(Console.ReadLine());

        // Input marks for Chemistry
        Console.WriteLine("Enter marks for Chemistry (0-100):");
        int chemistry = int.Parse(Console.ReadLine());

        // Input marks for Mathematics
        Console.WriteLine("Enter marks for Mathematics (0-100):");
        int maths = int.Parse(Console.ReadLine());

        // Validate input marks
        if (physics < 0 || physics > 100 || chemistry < 0 || chemistry > 100 || maths < 0 || maths > 100)
        {
            Console.WriteLine("Invalid input! Marks should be between 0 and 100.");
            return;
        }

        // Calculate total marks and percentage
        int totalMarks = physics + chemistry + maths;
        double percentage = totalMarks / 3.0;

        // Determine grade and level
        string grade;
        string level;

        if (percentage >= 80)
        {
            grade = "A";
            level = "Level 4";
        }
        else if (percentage >= 70)
        {
            grade = "B";
            level = "Level 3";
        }
        else if (percentage >= 60)
        {
            grade = "C";
            level = "Level 2";
        }
        else if (percentage >= 50)
        {
            grade = "D";
            level = "Level 1";
        }
        else if (percentage >= 40)
        {
            grade = "E";
            level = "Level 1-";
        }
        else
        {
            grade = "R";
            level = "Remedial Standards";
        }

        // Output results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Average Marks: " + percentage + "%");
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Level: " + level);
    }
}
