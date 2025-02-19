using System;
using System.Collections.Generic;

class BankingSystem {
    static void Main() {
        Dictionary<int, double> accountBalances = new Dictionary<int, double> {
            { 101, 5000 }, { 102, 3000 }, { 103, 7000 }
        };

        SortedDictionary<int, double> sortedAccounts = new SortedDictionary<int, double>(accountBalances);
        Queue<int> withdrawalQueue = new Queue<int>();

        // Simulating withdrawals
        withdrawalQueue.Enqueue(101);
        withdrawalQueue.Enqueue(103);

        Console.WriteLine("Processing Withdrawals:");
        while (withdrawalQueue.Count > 0) {
            int account = withdrawalQueue.Dequeue();
            Console.WriteLine("Processing withdrawal for account: " + account);
        }
    }
}
