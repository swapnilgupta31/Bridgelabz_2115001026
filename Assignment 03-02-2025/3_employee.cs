using System;
class Employee {
    static string companyName = "TechCorp"; // Static variable (shared across all employees)
    static int totalEmployees = 0; // Static variable to count total employees

    public readonly int id; // Readonly variable (cannot be changed after assignment)
    public string name; // Instance variable for employee name
    public string designation; // Instance variable for employee designation

    // Constructor to initialize employee details
    public Employee(int id, string name, string designation) {
        this.id = id; // Using 'this' to differentiate instance variable
        this.name = name;
        this.designation = designation;

        totalEmployees++; // Increment employee count
    }

    // Static method to display total employees
    public static void DisplayTotalEmployees() {
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    // Method to display employee details
    public void DisplayEmployeeDetails() {
        if (this is Employee) { // Using 'is' to check type before displaying
            Console.WriteLine("\nCompany: " + companyName);
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Designation: " + designation);
        } else {
            Console.WriteLine("Invalid Employee");
        }
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating employee objects
        Employee emp1 = new Employee(101, "John Smith", "Software Engineer");
        Employee emp2 = new Employee(102, "Jane Doe", "Project Manager");

        // Display employee details
        emp1.DisplayEmployeeDetails();
        emp2.DisplayEmployeeDetails();

        // Display total employees using static method
        Employee.DisplayTotalEmployees();
    }
}
