using System;

class Student {
    static string universityName = "XYZ University"; // Static variable shared across all students
    static int totalStudents = 0; // Static variable to count total students
    public readonly int rollNumber; // Readonly variable to ensure uniqueness
    public string name;
    public string grade;

    // Constructor to initialize student details
    public Student(int rollNumber, string name, string grade) {
        this.rollNumber = rollNumber; // 'this' differentiates instance and parameter variables
        this.name = name;
        this.grade = grade;

        totalStudents++; // Increment student count
    }

    // Static method to display total students
    public static void DisplayTotalStudents() {
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
    }

    // Method to display student details
    public void DisplayStudentDetails() {
        if (this is Student) { // 'is' operator to validate type
            Console.WriteLine("\nUniversity: " + universityName);
            Console.WriteLine("Roll Number: " + rollNumber);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Grade: " + grade);
        } else {
            Console.WriteLine("Invalid Student");
        }
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating student objects
        Student student1 = new Student(1001, "John Doe", "A");
        Student student2 = new Student(1002, "Alice Smith", "B");

        // Displaying student details
        student1.DisplayStudentDetails();
        student2.DisplayStudentDetails();

        // Displaying total students
        Student.DisplayTotalStudents();
    }
}
