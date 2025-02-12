using System;
public class BankAccount {
    // Private fields - data hiding
    private string accountNumber;
    private double balance;

    // Constructor to initialize account details
    public BankAccount(string accountNumber, double initialBalance) {
        this.accountNumber = accountNumber;
        Balance = initialBalance; // Using property for validation
    }

    // Public read-only property for Account Number
    public string AccountNumber {
        get { return accountNumber; }
    }

    // Public property for balance with validation
    public double Balance {
        get { return balance; }
        private set {
            if (value >= 0)
                balance = value;
            else
                Console.WriteLine("Balance cannot be negative.");
        }
    }

    // Method to deposit money
    public void Deposit(double amount) {
        if (amount > 0) {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        } else {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    // Method to withdraw money
    public void Withdraw(double amount) {
        if (amount > 0 && amount <= balance) {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        } else {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    // Method to display account information
    public void DisplayAccountInfo() {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Current Balance: " + balance);
    }
}

// Main Program to demonstrate Encapsulation
class Program {
    static void Main() {
        // Creating a new Bank Account
        BankAccount account = new BankAccount("123456789", 500.0);

        // Display account details
        account.DisplayAccountInfo();

        // Deposit and display updated balance
        account.Deposit(150.0);
        account.DisplayAccountInfo();

        // Withdraw and display updated balance
        account.Withdraw(100.0);
        account.DisplayAccountInfo();

        // Attempting invalid operations
        account.Deposit(50000);  // Output: "Deposit amount must be positive."
        account.DisplayAccountInfo();
        account.Withdraw(1000); // Output: "Invalid withdrawal amount."
    }
}
