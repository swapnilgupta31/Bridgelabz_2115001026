using System;
using System.Collections.Generic;

class ReverseQueue {
    static void Main() {
        Queue<int> queue = new Queue<int>(new int[] { 10, 20, 30 });

        // Reverse the queue using a stack
        Stack<int> stack = new Stack<int>();
        while (queue.Count > 0) {
            stack.Push(queue.Dequeue());
        }
        while (stack.Count > 0) {
            queue.Enqueue(stack.Pop());
        }

        Console.WriteLine("Reversed Queue: " + string.Join(", ", queue));
    }
}
