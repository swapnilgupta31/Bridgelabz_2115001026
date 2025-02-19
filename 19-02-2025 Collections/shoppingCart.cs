using System;
using System.Collections.Generic;

class ShoppingCart {
    static void Main() {
        Dictionary<string, double> products = new Dictionary<string, double> {
            { "Laptop", 1000 }, { "Phone", 500 }, { "Tablet", 300 }
        };

        SortedDictionary<string, double> sortedProducts = new SortedDictionary<string, double>(products);

        Console.WriteLine("Products in Sorted Order:");
        foreach (var product in sortedProducts) {
            Console.WriteLine(product.Key + ": $" + product.Value);
        }
    }
}
