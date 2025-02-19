using System;
using System.Collections.Generic;
using System.Linq;

class Policy {
    public string PolicyNumber { get; set; }
    public string CoverageType { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Policy(string policyNumber, string coverageType, DateTime expiryDate) {
        PolicyNumber = policyNumber;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public override bool Equals(object obj) {
        return obj is Policy policy && PolicyNumber == policy.PolicyNumber;
    }

    public override int GetHashCode() {
        return PolicyNumber.GetHashCode();
    }
}

class InsuranceSystem {
    static void Main() {
        HashSet<Policy> uniquePolicies = new HashSet<Policy>(); // Unique policies
        LinkedList<Policy> orderedPolicies = new LinkedList<Policy>(); // Maintain insertion order
        SortedSet<Policy> sortedPolicies = new SortedSet<Policy>(Comparer<Policy>.Create((p1, p2) => p1.ExpiryDate.CompareTo(p2.ExpiryDate)));

        // Adding sample policies
        Policy p1 = new Policy("P1001", "Health", DateTime.Now.AddDays(25));
        Policy p2 = new Policy("P1002", "Life", DateTime.Now.AddDays(10));
        Policy p3 = new Policy("P1003", "Auto", DateTime.Now.AddDays(40));

        uniquePolicies.Add(p1); uniquePolicies.Add(p2); uniquePolicies.Add(p3);
        orderedPolicies.AddLast(p1); orderedPolicies.AddLast(p2); orderedPolicies.AddLast(p3);
        sortedPolicies.Add(p1); sortedPolicies.Add(p2); sortedPolicies.Add(p3);

        // Retrieve all unique policies
        Console.WriteLine("All Unique Policies:");
        foreach (var policy in uniquePolicies) {
            Console.WriteLine(policy.PolicyNumber + " - " + policy.CoverageType);
        }

        // Retrieve policies expiring in the next 30 days
        Console.WriteLine("\nPolicies Expiring Soon:");
        foreach (var policy in sortedPolicies.Where(p => p.ExpiryDate <= DateTime.Now.AddDays(30))) {
            Console.WriteLine(policy.PolicyNumber);
        }

        // Retrieve policies by coverage type
        Console.WriteLine("\nPolicies with Coverage Type 'Health':");
        foreach (var policy in uniquePolicies.Where(p => p.CoverageType == "Health")) {
            Console.WriteLine(policy.PolicyNumber);
        }
    }
}
