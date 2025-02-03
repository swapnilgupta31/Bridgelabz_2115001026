using System;

class BankAccount {
    static string bankName = "ABC Bank"; // Static variable (shared across all accounts)
    static int totalAccounts = 0; // Static variable to count total accounts

    public readonly int accountNumber; // Readonly variable (cannot be changed after assignment)
    public string accountHolderName; // Instance variable for name

    // Constructor to initialize account details
    public BankAccount(int accountNumber, string accountHolderName) {
        this.accountNumber = accountNumber; // Using 'this' to differentiate instance variable
        this.accountHolderName = accountHolderName;
        totalAccounts++; // Increment account count
    }

    // Static method to display total accounts
    public static void DisplayTotalAccounts() {
        Console.WriteLine("Total Bank Accounts: " + totalAccounts);
    }

    // Method to display account details
    public void DisplayAccountDetails() {
        if (this is BankAccount) { // Using 'is' to check type before displaying
            Console.WriteLine("\nBank: " + bankName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Account Holder Name: " + accountHolderName);
        } else {
            Console.WriteLine("Invalid Account");
        }
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating bank account objects
        BankAccount acc1 = new BankAccount(101, "John Doe");
        BankAccount acc2 = new BankAccount(102, "Alice Smith");

        // Display account details
        acc1.DisplayAccountDetails();
        acc2.DisplayAccountDetails();

        // Display total accounts using static method
        BankAccount.DisplayTotalAccounts();
    }
}
