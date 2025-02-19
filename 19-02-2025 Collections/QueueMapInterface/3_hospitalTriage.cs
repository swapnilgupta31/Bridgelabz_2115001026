using System;
using System.Collections.Generic;

class HospitalTriage {
    static void Main() {
        PriorityQueue<string, int> triageQueue = new PriorityQueue<string, int>();

        // Adding patients with priority (higher number = higher priority)
        triageQueue.Enqueue("John", -3);
        triageQueue.Enqueue("Alice", -5);
        triageQueue.Enqueue("Bob", -2);

        Console.WriteLine("Treated Patients in Order:");
        while (triageQueue.Count > 0) {
            Console.WriteLine(triageQueue.Dequeue());
        }
    }
}
