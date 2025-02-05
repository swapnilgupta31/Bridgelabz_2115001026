using System;
using System.Collections.Generic;

class Faculty {
    public string FacultyName { get; set; }

    public Faculty(string name) {
        FacultyName = name;
    }

    public void DisplayFaculty() {
        Console.WriteLine("Faculty Member: " + FacultyName);
    }
}

class Department {
    public string DepartmentName { get; set; }

    public Department(string name) {
        DepartmentName = name;
    }

    public void DisplayDepartment() {
        Console.WriteLine("Department: " + DepartmentName);
    }
}

class University {
    public string UniversityName { get; set; }
    private List<Department> departments; // Composition
    private List<Faculty> faculties; // Aggregation

    public University(string name) {
        UniversityName = name;
        departments = new List<Department>();
        faculties = new List<Faculty>();
    }

    public void AddDepartment(string deptName) {
        departments.Add(new Department(deptName)); // Composition: University owns Departments
    }

    public void AddFaculty(Faculty faculty) {
        faculties.Add(faculty); // Aggregation: Faculty members exist independently
    }

    public void DisplayDetails() {
        Console.WriteLine("University: " + UniversityName);
        Console.WriteLine("Departments:");
        foreach (var dept in departments) {
            dept.DisplayDepartment();
        }
        Console.WriteLine("Faculties:");
        foreach (var faculty in faculties) {
            faculty.DisplayFaculty();
        }
    }

    public void DeleteUniversity() {
        Console.WriteLine("\nDeleting University: " + UniversityName);
        departments.Clear(); // Deleting University deletes all Departments (Composition)
        Console.WriteLine("All departments deleted!");
    }
}

class Program {
    static void Main() {
        // Creating University
        University myUniversity = new University("Tech University");

        // Adding Departments (Composition)
        myUniversity.AddDepartment("Computer Science");
        myUniversity.AddDepartment("Mechanical Engineering");

        // Creating Faculty Members (Aggregation)
        Faculty faculty1 = new Faculty("Dr. Smith");
        Faculty faculty2 = new Faculty("Prof. Johnson");

        // Adding Faculty Members to University (But they exist independently)
        myUniversity.AddFaculty(faculty1);
        myUniversity.AddFaculty(faculty2);

        // Displaying University Details
        myUniversity.DisplayDetails();

        // Deleting University
        myUniversity.DeleteUniversity();

        // Faculties Still Exist
        Console.WriteLine("\nFaculty Members still exist independently:");
        faculty1.DisplayFaculty();
        faculty2.DisplayFaculty();
    }
}
