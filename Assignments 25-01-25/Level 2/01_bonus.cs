using System;

class BonusCalculation
{
    public static void Main(String[] args)
    {
        // Define arrays and variables
        double[] salaries = new double[10];
        double[] yearsOfService = new double[10];
        double[] bonuses = new double[10];
        double[] newSalaries = new double[10];
        double totalBonus = 0.0, totalOldSalary = 0.0, totalNewSalary = 0.0;

        // Input data for salaries and years of service
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter the salary of employee " + (i + 1) + ": ");
            salaries[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the years of service of employee " + (i + 1) + ": ");
            yearsOfService[i] = double.Parse(Console.ReadLine());

            // Validate input for salary and years of service
            if (salaries[i] < 0 || yearsOfService[i] < 0)
            {
                Console.WriteLine("Invalid input. Please enter valid salary and years of service.");
                i--; // decrement the index to re-enter values
                continue;
            }
        }

        // Calculate bonus, new salary, and total salary amounts
        for (int i = 0; i < 10; i++)
        {
            // Calculate bonus based on years of service
            if (yearsOfService[i] > 5)
            {
                bonuses[i] = salaries[i] * 0.05; // 5% bonus
            }
            else
            {
                bonuses[i] = salaries[i] * 0.02; // 2% bonus
            }

            // Calculate new salary
            newSalaries[i] = salaries[i] + bonuses[i];

            // Update total bonus, total old salary, and total new salary
            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }

        // Print total bonus payout, old and new salary
        Console.WriteLine("Total bonus payout: " + totalBonus);
        Console.WriteLine("Total old salary: " + totalOldSalary);
        Console.WriteLine("Total new salary: " + totalNewSalary);
    }
}
