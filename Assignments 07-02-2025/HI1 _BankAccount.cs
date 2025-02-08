using System;

// Base class: BankAccount
class BankAccount {
    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    public void DisplayAccountInfo() {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Balance: " + Balance);
    }
}

// Subclass: SavingsAccount
class SavingsAccount : BankAccount {
    public double InterestRate { get; set; }

    public void DisplayAccountType() {
        Console.WriteLine("Account Type: Savings Account");
        Console.WriteLine("Interest Rate: " + InterestRate + "%");
    }
}

// Subclass: CheckingAccount
class CheckingAccount : BankAccount {
    public double WithdrawalLimit { get; set; }

    public void DisplayAccountType() {
        Console.WriteLine("Account Type: Checking Account");
        Console.WriteLine("Withdrawal Limit: " + WithdrawalLimit);
    }
}

// Subclass: FixedDepositAccount
class FixedDepositAccount : BankAccount {
    public int DepositTerm { get; set; } // Term in months

    public void DisplayAccountType() {
        Console.WriteLine("Account Type: Fixed Deposit Account");
        Console.WriteLine("Deposit Term: " + DepositTerm + " months");
    }
}

// Main program
class Program {
    public static void Main(string[] args) {
        // Creating different account objects
        SavingsAccount savings = new SavingsAccount();
        savings.AccountNumber = 101;
        savings.Balance = 5000;
        savings.InterestRate = 4.5;
        
        CheckingAccount checking = new CheckingAccount();
        checking.AccountNumber = 202;
        checking.Balance = 3000;
        checking.WithdrawalLimit = 1000;
        
        FixedDepositAccount fixedDeposit = new FixedDepositAccount();
        fixedDeposit.AccountNumber = 303;
        fixedDeposit.Balance = 10000;
        fixedDeposit.DepositTerm = 12;

        // Displaying account details
        savings.DisplayAccountInfo();
        savings.DisplayAccountType();
        Console.WriteLine();

        checking.DisplayAccountInfo();
        checking.DisplayAccountType();
        Console.WriteLine();

        fixedDeposit.DisplayAccountInfo();
        fixedDeposit.DisplayAccountType();
    }
}
