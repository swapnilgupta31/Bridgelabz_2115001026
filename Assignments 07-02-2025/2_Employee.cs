using System;
class Employee{
    public string Name{get;set;}
    public int ID{get; set;}
    public double Salary{get; set;}

    public virtual void DisplayDetails(){
        Console.WriteLine("Name: "+ Name +"\nID: "+ ID + "\nSalary: "+ Salary);
}
}
class Manager:Employee {
    public int TeamSize{get; set;}
    public override void DisplayDetails(){
        base.DisplayDetails(); // Call base class Method
        Console.WriteLine("Employee Type: Manager\nTeam Size: " + TeamSize +"\n");
    }
}
class Developer:Employee {
    public string ProgrammingLanguage{get; set;}
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine( "Employee Type: Developer\nProgramming Language: " + ProgrammingLanguage +"\n");
    }
}

class Intern:Employee {
    public string InternshipDuration{get; set;}
    public override void DisplayDetails(){
        base.DisplayDetails();
        Console.WriteLine("Employee Type: Intern\nInternship Duration: " + InternshipDuration +"\n");
    }
}
class Program{
    public static void Main(string [] args){
         Employee employee = new Manager { Name = "Swapnil", ID = 2115, Salary = 225000, TeamSize = 15 };
        employee.DisplayDetails();
        
        employee = new Developer { Name = "Edwin", ID = 2256, Salary = 125000, ProgrammingLanguage = "C#" };
        employee.DisplayDetails();
       
        employee = new Intern { Name = "Neil", ID = 2341, Salary = 25000, InternshipDuration = "5 months" };
        employee.DisplayDetails();
        
    }
}