using System;

class Student {
    public int rollNumber;
    protected string name;
    private double CGPA;

    // Constructor
    public Student(int rollNumber, string name, double CGPA) {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    // Public method to get CGPA
    public double GetCGPA() {
        return CGPA;
    }

    // Public method to update CGPA
    public void SetCGPA(double newCGPA) {
        CGPA = newCGPA;
    }
}

// Subclass using protected member
class PostgraduateStudent : Student {
    public string researchTopic;

    public PostgraduateStudent(int rollNumber, string name, double CGPA, string researchTopic) 
        : base(rollNumber, name, CGPA) {
        this.researchTopic = researchTopic;
    }

    public void DisplayStudentDetails() {
        Console.WriteLine("Roll Number: " + rollNumber);
        Console.WriteLine("Name: " + name); // Protected member accessible
        Console.WriteLine("Research Topic: " + researchTopic);
    }
}

class Program {
    static void Main() {
        PostgraduateStudent pg = new PostgraduateStudent(101, "Alice", 8.5, "AI Research");
        pg.DisplayStudentDetails();
        
        Console.WriteLine("CGPA (Using Method): " + pg.GetCGPA());

        pg.SetCGPA(9.0);
        Console.WriteLine("Updated CGPA: " + pg.GetCGPA());
    }
}
