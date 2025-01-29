using System;

public class EmployeeBonus
{
    // Method to determine salary and years of service for employees
    public static double[,] GetEmployeeData(int numberOfEmployees)
    {
        Random random = new Random();
        double[,] employeeData = new double[numberOfEmployees, 2]; // [i, 0] = salary, [i, 1] = years of service

        for (int i = 0; i < numberOfEmployees; i++)
        {
            // Random 5-digit salary between 10000 and 99999
            employeeData[i, 0] = random.Next(10000, 100000);
            // Random years of service between 1 and 20 years
            employeeData[i, 1] = random.Next(1, 21);
        }

        return employeeData;
    }

    // Method to calculate the new salary and bonus based on the years of service
    public static double[,] CalculateNewSalaryAndBonus(double[,] employeeData, int numberOfEmployees)
    {
        double[,] updatedData = new double[numberOfEmployees, 3]; // [i, 0] = old salary, [i, 1] = bonus, [i, 2] = new salary

        for (int i = 0; i < numberOfEmployees; i++)
        {
            double oldSalary = employeeData[i, 0];
            double yearsOfService = employeeData[i, 1];

            // Calculate bonus: 5% if years of service > 5, else 2%
            double bonus = (yearsOfService > 5) ? oldSalary * 0.05 : oldSalary * 0.02;
            double newSalary = oldSalary + bonus;

            // Store the old salary, bonus, and new salary in updatedData
            updatedData[i, 0] = oldSalary;
            updatedData[i, 1] = bonus;
            updatedData[i, 2] = newSalary;
        }

        return updatedData;
    }

    // Method to calculate and display the sum of the old salary, new salary, and total bonus
    public static void DisplayEmployeeData(double[,] updatedData, int numberOfEmployees)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        // Display the header
        Console.WriteLine("Employee No\tOld Salary\tBonus\tNew Salary");

        // Display the employee data and calculate totals
        for (int i = 0; i < numberOfEmployees; i++)
        {
            double oldSalary = updatedData[i, 0];
            double bonus = updatedData[i, 1];
            double newSalary = updatedData[i, 2];

            // Update totals
            totalOldSalary += oldSalary;
            totalNewSalary += newSalary;
            totalBonus += bonus;

            // Display the employee data in tabular format
            Console.WriteLine($"{i + 1}\t\t{oldSalary:C}\t{bonus:C}\t{newSalary:C}");
        }

        // Display the total amounts
        Console.WriteLine("\nTotal Old Salary: " + totalOldSalary.ToString("C"));
        Console.WriteLine("Total New Salary: " + totalNewSalary.ToString("C"));
        Console.WriteLine("Total Bonus: " + totalBonus.ToString("C"));
    }

    public static void Main(string[] args)
    {
        int numberOfEmployees = 10;

        // Step 1: Get the employee data (salary and years of service)
        double[,] employeeData = GetEmployeeData(numberOfEmployees);

        // Step 2: Calculate new salary and bonus
        double[,] updatedData = CalculateNewSalaryAndBonus(employeeData, numberOfEmployees);

        // Step 3: Display the data
        DisplayEmployeeData(updatedData, numberOfEmployees);
    }
}
