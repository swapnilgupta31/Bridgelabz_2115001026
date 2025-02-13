using System;
using System.Collections.Generic;

class SortStackRecursively {
    // Function to sort the stack
    public static void SortStack(Stack<int> stack) {
        if (stack.Count > 0) {
            int top = stack.Pop(); // Remove the top element
            SortStack(stack); // Recursively sort the remaining stack
            InsertInSortedOrder(stack, top); // Insert the top element in the correct position
        }
    }

    // Function to insert an element into the sorted stack
    private static void InsertInSortedOrder(Stack<int> stack, int value) {
        if (stack.Count == 0 || stack.Peek() >= value) {
            stack.Push(value); // Push value if stack is empty or correct position found
        } else {
            int temp = stack.Pop(); // Remove top element
            InsertInSortedOrder(stack, value); // Recursively find correct position
            stack.Push(temp); // Push back the removed element
        }
    }

    // Function to display stack
    public static void DisplayStack(Stack<int> stack) {
        foreach (var item in stack) {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main() {
        Stack<int> stack = new Stack<int>();
        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);

        Console.WriteLine("Original Stack:");
        DisplayStack(stack);

        SortStack(stack);

        Console.WriteLine("Sorted Stack:");
        DisplayStack(stack);
    }
}
