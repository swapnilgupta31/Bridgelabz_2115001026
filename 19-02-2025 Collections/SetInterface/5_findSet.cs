using System;
using System.Collections.Generic;

class SubsetCheck {
    static void Main() {
        HashSet<int> smallSet = new HashSet<int> { 2, 3 };
        HashSet<int> largeSet = new HashSet<int> { 1, 2, 3, 4 };

        bool isSubset = smallSet.IsSubsetOf(largeSet); // Checks if smallSet is a subset of largeSet

        Console.WriteLine("Is Subset: " + isSubset);
    }
}
