using System;
using System.Collections.Generic;

class Bank {
    public string BankName { get; set; }
    private List<Account> accounts;

    public Bank(string bankName) {
        BankName = bankName;
        accounts = new List<Account>(); // Initialize account list
    }

    public void OpenAccount(Customer customer, double initialDeposit) {
        Account newAccount = new Account(customer, this, initialDeposit);
        accounts.Add(newAccount);
        customer.AddAccount(newAccount);
        Console.WriteLine("Account opened for " + customer.Name + " in " + BankName + " with balance: " + initialDeposit);
    }

    public void DisplayBankAccounts() {
        Console.WriteLine("Bank: " + BankName + " - Accounts:");
        if (accounts.Count == 0) {
            Console.WriteLine("No accounts available.");
        } else {
            foreach (Account acc in accounts) {
                acc.DisplayAccountInfo();
            }
        }
    }
}

class Customer {
    public string Name { get; set; }
    private List<Account> accounts;

    public Customer(string name) {
        Name = name;
        accounts = new List<Account>(); // Initialize account list
    }

    public void AddAccount(Account account) {
        accounts.Add(account);
    }

    public void ViewBalance() {
        Console.WriteLine("Customer: " + Name + " - Accounts:");
        if (accounts.Count == 0) {
            Console.WriteLine("No accounts found.");
        } else {
            foreach (Account acc in accounts) {
                acc.DisplayAccountInfo();
            }
        }
    }
}

class Account {
    public Customer AccountHolder { get; set; }
    public Bank Bank { get; set; }
    public double Balance { get; private set; }

    public Account(Customer accountHolder, Bank bank, double initialDeposit) {
        AccountHolder = accountHolder;
        Bank = bank;
        Balance = initialDeposit;
    }

    public void DisplayAccountInfo() {
        Console.WriteLine("Bank: " + Bank.BankName + ", Holder: " + AccountHolder.Name + ", Balance: " + Balance);
    }
}

class Program {
    static void Main() {
        // Creating Banks
        Bank bank1 = new Bank("State Bank");
        Bank bank2 = new Bank("City Bank");

        // Creating Customers
        Customer customer1 = new Customer("Alice");
        Customer customer2 = new Customer("Bob");

        // Opening Accounts
        bank1.OpenAccount(customer1, 5000);
        bank1.OpenAccount(customer2, 3000);
        bank2.OpenAccount(customer1, 7000);

        // Viewing Customer Accounts
        Console.WriteLine();
        customer1.ViewBalance();
        Console.WriteLine();
        customer2.ViewBalance();
        Console.WriteLine();

        // Displaying Bank Accounts
        bank1.DisplayBankAccounts();
        Console.WriteLine();
        bank2.DisplayBankAccounts();
    }
}
