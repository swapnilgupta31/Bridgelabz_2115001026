using System;

// Base class: Person
class Person {
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo() {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

// Subclass: Teacher
class Teacher : Person {
    public string Subject { get; set; }

    public void DisplayRole() {
        Console.WriteLine("Role: Teacher");
        Console.WriteLine("Subject: " + Subject);
    }
}

// Subclass: Student
class Student : Person {
    public int Grade { get; set; }

    public void DisplayRole() {
        Console.WriteLine("Role: Student");
        Console.WriteLine("Grade: " + Grade);
    }
}

// Subclass: Staff
class Staff : Person {
    public string Department { get; set; }

    public void DisplayRole() {
        Console.WriteLine("Role: Staff");
        Console.WriteLine("Department: " + Department);
    }
}

// Main program
class Program {
    public static void Main(string[] args) {
        // Creating teacher, student, and staff objects
        Teacher teacher = new Teacher();
        teacher.Name = "Mr. Smith";
        teacher.Age = 40;
        teacher.Subject = "Mathematics";

        Student student = new Student();
        student.Name = "Alice";
        student.Age = 16;
        student.Grade = 10;

        Staff staff = new Staff();
        staff.Name = "Mrs. Johnson";
        staff.Age = 35;
        staff.Department = "Administration";

        // Displaying details
        teacher.DisplayInfo();
        teacher.DisplayRole();
        Console.WriteLine();

        student.DisplayInfo();
        student.DisplayRole();
        Console.WriteLine();

        staff.DisplayInfo();
        staff.DisplayRole();
    }
}
