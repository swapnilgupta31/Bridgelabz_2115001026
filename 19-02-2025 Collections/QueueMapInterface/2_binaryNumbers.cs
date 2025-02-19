using System;
using System.Collections.Generic;

class BinaryNumbers {
    static void Main() {
        int N = 5; // Number of binary numbers to generate
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("1");

        Console.Write("Binary Numbers: ");
        for (int i = 0; i < N; i++) {
            string binary = queue.Dequeue();
            Console.Write(binary + " ");

            queue.Enqueue(binary + "0");
            queue.Enqueue(binary + "1");
        }
    }
}
