using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Employee {
    public int Id;
    public string Name;
    public string Department;
    public double Salary;
}

class EmployeeSerialization {
    static void Main() {
        List<Employee> employees = new List<Employee> {
            new Employee { Id = 1, Name = "Alice", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Bob", Department = "HR", Salary = 40000 }
        };

        // Serialize to file
        using (FileStream stream = new FileStream("employees.dat", FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, employees);
        }

        // Deserialize and display
        using (FileStream stream = new FileStream("employees.dat", FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            List<Employee> deserializedEmployees = (List<Employee>)formatter.Deserialize(stream);
            foreach (var emp in deserializedEmployees) {
                Console.WriteLine(emp.Name + " - " + emp.Department);
            }
        }
    }
}
