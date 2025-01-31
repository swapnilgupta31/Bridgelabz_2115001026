using System;
class Employee{
    private string name; //employee name 
    private int id; //Enployee ID
    private double salary ; // Employee salary

    //Constructor to initialize attributes
    public Employee(string name , int id , double salary){
        this.name = name ;
        this.id = id ;
        this.salary = salary;
    }

    //Method to display employee details
    public void DisplayDetails(){
        Console.WriteLine("Employee ID: "+ id);
        Console.WriteLine("Name: "+ name);
        Console.WriteLine("Salary: "+ salary);
    }
}
class Program {
    static void Main(){
        //creating Employee objects
        Employee emp1 = new Employee("Johj Doe",101,50000);
        Employee emp2 = new Employee("Alice Smith",102 ,60000);

        //Displaying details
        Console.WriteLine("Employee 1");
        emp1.DisplayDetails();

        Console.WriteLine("\nEmployee2");
        emp2.DisplayDetails();
    }
}