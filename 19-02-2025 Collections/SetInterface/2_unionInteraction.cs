using System;
using System.Collections.Generic;

class SetOperations {
    static void Main() {
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2); // Union of sets

        HashSet<int> intersectionSet = new HashSet<int>(set1);
        intersectionSet.IntersectWith(set2); // Intersection of sets

        Console.WriteLine("Union: " + string.Join(", ", unionSet));
        Console.WriteLine("Intersection: " + string.Join(", ", intersectionSet));
    }
}
