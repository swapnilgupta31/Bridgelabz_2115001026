using System;

class EmployeeBonus
{
    static void Main(string[] args)
    {
        // Prompt the user to enter the salary
        Console.WriteLine("Enter the employee's salary:");
        double salary = double.Parse(Console.ReadLine());

        // Prompt the user to enter the years of service
        Console.WriteLine("Enter the years of service:");
        int yearsOfService = int.Parse(Console.ReadLine());

        // Check if years of service is more than 5
        if (yearsOfService > 5)
        {
            // Calculate the bonus (5% of the salary)
            double bonus = salary * 0.05;

            // Print the bonus amount
            Console.WriteLine("The bonus amount is: " + bonus);
        }
        else
        {
            // If no bonus, display a message
            Console.WriteLine("No bonus as the years of service are 5 or less.");
        }
    }
}
