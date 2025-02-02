using System;

class Course {
    string courseName;
    int duration, fee;
    static string instituteName = "ABC Institute"; // Class Variable

    // Constructor
    public Course(string courseName, int duration, int fee) {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance Method to display course details
    public void DisplayCourseDetails() {
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " months");
        Console.WriteLine("Fee: Rs. " + fee);
        Console.WriteLine("Institute: " + instituteName);
    }

    // Class Method to update institute name
    public static void UpdateInstituteName(string newName) {
        instituteName = newName;
    }
}

class Program {
    static void Main() {
        Course c1 = new Course("C# Programming", 3, 10000);
        Course c2 = new Course("Python Programming", 4, 12000);

        Console.WriteLine("Before Institute Name Update:");
        c1.DisplayCourseDetails();
        Console.WriteLine();
        c2.DisplayCourseDetails();

        Console.WriteLine("\nUpdating Institute Name...");
        Course.UpdateInstituteName("XYZ Tech Academy");

        Console.WriteLine("\nAfter Institute Name Update:");
        c1.DisplayCourseDetails();
        Console.WriteLine();
        c2.DisplayCourseDetails();
    }
}
