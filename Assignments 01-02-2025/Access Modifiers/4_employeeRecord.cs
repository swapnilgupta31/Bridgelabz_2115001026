using System;

class Employee {
    public int employeeID;
    protected string department;
    private double salary;

    // Constructor
    public Employee(int employeeID, string department, double salary) {
        this.employeeID = employeeID;
        this.department = department;
        this.salary = salary;
    }

    // Public method to get salary
    public double GetSalary() {
        return salary;
    }

    // Public method to update salary
    public void SetSalary(double newSalary) {
        salary = newSalary;
    }
}

// Subclass using protected member
class Manager : Employee {
    public string role;

    public Manager(int employeeID, string department, double salary, string role) 
        : base(employeeID, department, salary) {
        this.role = role;
    }

    public void DisplayEmployeeDetails() {
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department); // Protected member accessible
        Console.WriteLine("Role: " + role);
    }
}

class Program {
    static void Main() {
        Manager mgr = new Manager(101, "IT", 75000, "Project Manager");
        mgr.DisplayEmployeeDetails();

        Console.WriteLine("Salary: Rs. " + mgr.GetSalary());

        mgr.SetSalary(80000);
        Console.WriteLine("Updated Salary: Rs. " + mgr.GetSalary());
    }
}
