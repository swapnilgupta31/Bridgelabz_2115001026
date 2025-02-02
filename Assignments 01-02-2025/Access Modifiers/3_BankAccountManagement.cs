using System;

class BankAccount {
    public int accountNumber;
    protected string accountHolder;
    private double balance;

    // Constructor
    public BankAccount(int accountNumber, string accountHolder, double balance) {
        this.accountNumber = accountNumber;
        this.accountHolder = accountHolder;
        this.balance = balance;
    }

    // Public method to get balance
    public double GetBalance() {
        return balance;
    }

    // Public method to modify balance
    public void Deposit(double amount) {
        balance += amount;
    }
}

// Subclass using protected member
class SavingsAccount : BankAccount {
    public double interestRate;

    public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate) 
        : base(accountNumber, accountHolder, balance) {
        this.interestRate = interestRate;
    }

    public void DisplayAccountDetails() {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder); // Protected member accessible
        Console.WriteLine("Interest Rate: " + interestRate + "%");
    }
}

class Program {
    static void Main() {
        SavingsAccount sa = new SavingsAccount(987654, "Alice", 10000, 5.5);
        sa.DisplayAccountDetails();

        Console.WriteLine("Balance: Rs. " + sa.GetBalance());

        sa.Deposit(2000);
        Console.WriteLine("Updated Balance: Rs. " + sa.GetBalance());
    }
}
