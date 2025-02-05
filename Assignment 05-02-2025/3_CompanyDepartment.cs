using System;
using System.Collections.Generic;

class Employee {
    public string Name { get; set; }
    
    public Employee(string name) {
        Name = name;
    }

    public void DisplayEmployee() {
        Console.WriteLine("    Employee: " + Name);
    }
}

class Department {
    public string DepartmentName { get; set; }
    private List<Employee> employees; 

    public Department(string departmentName) {
        DepartmentName = departmentName;
        employees = new List<Employee>();
    }

    public void AddEmployee(string empName) {
        employees.Add(new Employee(empName));
    }

    public void DisplayDepartment() {
        Console.WriteLine("  Department: " + DepartmentName);
        foreach (var emp in employees) {
            emp.DisplayEmployee();
        }
    }
}

class Company {
    public string CompanyName { get; set; }
    private List<Department> departments;

    public Company(string companyName) {
        CompanyName = companyName;
        departments = new List<Department>();
    }

    public void AddDepartment(Department dept) {
        departments.Add(dept);
    }

    public void DisplayCompany() {
        Console.WriteLine("Company: " + CompanyName);
        foreach (var dept in departments) {
            dept.DisplayDepartment();
        }
    }
}

class Program {
    static void Main() {
        // Creating a Company
        Company myCompany = new Company("Tech Solutions");

        // Creating Departments
        Department dept1 = new Department("IT");
        Department dept2 = new Department("HR");

        // Adding Employees to Departments
        dept1.AddEmployee("Alice");
        dept1.AddEmployee("Bob");
        dept2.AddEmployee("Charlie");

        // Adding Departments to Company
        myCompany.AddDepartment(dept1);
        myCompany.AddDepartment(dept2);

        // Displaying Company Details
        myCompany.DisplayCompany();

        // Deleting Company (Composition ensures all Departments & Employees are removed)
        myCompany = null;
        Console.WriteLine("\nCompany deleted. Departments and Employees no longer exist.");
    }
}
