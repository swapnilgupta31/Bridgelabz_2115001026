using System;
using System.Collections.Generic;

// Abstract Class: BankAccount
abstract class BankAccount {
    protected string accountNumber;
    protected string holderName;
    protected double balance;

    // Constructor
    public BankAccount(string accountNumber, string holderName, double balance) {
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }

    // Deposit Method
    public void Deposit(double amount) {
        balance += amount;
        Console.WriteLine("Deposited: " + amount + ", New Balance: " + balance);
    }

    // Withdraw Method
    public void Withdraw(double amount) {
        if (balance >= amount) {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount + ", Remaining Balance: " + balance);
        } else {
            Console.WriteLine("Insufficient funds for withdrawal.");
        }
    }

    // Abstract Method for Interest Calculation
    public abstract double CalculateInterest();

    // Display Account Details
    public void DisplayDetails() {
        Console.WriteLine("Account No: " + accountNumber + ", Holder: " + holderName + ", Balance: " + balance);
    }
}

// Interface for Loan Processing
interface ILoanable {
    void ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}

// Concrete Class: SavingsAccount (Implements ILoanable)
class SavingsAccount : BankAccount, ILoanable {
    private double interestRate = 0.04; // 4% interest
    private double loanLimitMultiplier = 5; // Loan eligibility = 5 times balance

    public SavingsAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) {}

    public override double CalculateInterest() {
        return balance * interestRate;
    }

    public void ApplyForLoan(double amount) {
        if (amount <= CalculateLoanEligibility()) {
            Console.WriteLine("Loan Approved for Amount: " + amount);
        } else {
            Console.WriteLine("Loan Denied. Maximum Eligible Loan: " + CalculateLoanEligibility());
        }
    }

    public double CalculateLoanEligibility() {
        return balance * loanLimitMultiplier;
    }
}

// Concrete Class: CurrentAccount (No Loan Feature)
class CurrentAccount : BankAccount {
    private double interestRate = 0.02; // 2% interest

    public CurrentAccount(string accountNumber, string holderName, double balance) : base(accountNumber, holderName, balance) {}

    public override double CalculateInterest() {
        return balance * interestRate;
    }
}

// Main Program
class Program {
    static void Main() {
        // Creating Account List
        List<BankAccount> accounts = new List<BankAccount> {
            new SavingsAccount("SA123", "Alice", 20000),
            new CurrentAccount("CA456", "Bob", 50000)
        };

        // Displaying Account Details and Calculating Interest
        foreach (BankAccount acc in accounts) {
            acc.DisplayDetails();
            Console.WriteLine("Interest Earned: " + acc.CalculateInterest());

            // Explicit Type Checking for Loan Feature
            if (acc is SavingsAccount) {
                Console.WriteLine("Loan Eligibility: " + ((SavingsAccount)acc).CalculateLoanEligibility());
                ((SavingsAccount)acc).ApplyForLoan(60000);
            }

            Console.WriteLine();
        }
    }
}
