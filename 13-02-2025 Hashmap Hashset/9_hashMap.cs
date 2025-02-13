using System;
using System.Collections.Generic;

class MyHashMap<K, V> {
    private const int Capacity = 10; // Default bucket size
    private LinkedList<KeyValuePair<K, V>>[] buckets;

    public MyHashMap() {
        buckets = new LinkedList<KeyValuePair<K, V>>[Capacity];
        for (int i = 0; i < Capacity; i++)
            buckets[i] = new LinkedList<KeyValuePair<K, V>>();
    }

    private int GetIndex(K key) {
        return Math.Abs(key.GetHashCode()) % Capacity; // Compute hash index
    }

    public void Put(K key, V value) {
        int index = GetIndex(key);
        var bucket = buckets[index];

        foreach (var pair in bucket) {
            if (pair.Key.Equals(key)) { // Key exists, update value
                bucket.Remove(pair);
                break;
            }
        }

        bucket.AddLast(new KeyValuePair<K, V>(key, value)); // Insert new pair
    }

    public V Get(K key) {
        int index = GetIndex(key);
        var bucket = buckets[index];

        foreach (var pair in bucket) {
            if (pair.Key.Equals(key))
                return pair.Value; // Return value if key found
        }

        return default(V); // Return default value if key not found
    }

    public void Remove(K key) {
        int index = GetIndex(key);
        var bucket = buckets[index];

        foreach (var pair in bucket) {
            if (pair.Key.Equals(key)) {
                bucket.Remove(pair);
                return; // Stop after removal
            }
        }
    }

    public void Display() {
        for (int i = 0; i < Capacity; i++) {
            Console.Write("Bucket " + i + ": ");
            foreach (var pair in buckets[i])
                Console.Write("(" + pair.Key + ", " + pair.Value + ") ");
            Console.WriteLine();
        }
    }
}

class Program {
    static void Main() {
        MyHashMap<string, int> map = new MyHashMap<string, int>();

        map.Put("apple", 10);
        map.Put("banana", 20);
        map.Put("orange", 30);
        map.Put("banana", 25); // Update existing key

        Console.WriteLine("Get banana: " + map.Get("banana")); // 25
        Console.WriteLine("Get apple: " + map.Get("apple"));   // 10

        map.Remove("apple");
        Console.WriteLine("Get apple after removal: " + map.Get("apple")); // Default value (0)

        map.Display(); // Print the hash map structure
    }
}
