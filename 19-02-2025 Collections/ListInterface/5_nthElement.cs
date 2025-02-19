using System;
using System.Collections.Generic;

class FindNthFromEnd {
    static void Main() {
        LinkedList<char> list = new LinkedList<char>(new char[] { 'A', 'B', 'C', 'D', 'E' });
        int n = 2;
        char result = FindNthElementFromEnd(list, n);

        Console.WriteLine("Nth element from the end: " + result);
    }

    static char FindNthElementFromEnd(LinkedList<char> list, int n) {
        LinkedListNode<char> first = list.First;
        LinkedListNode<char> second = list.First;

        // Move first pointer n steps ahead
        for (int i = 0; i < n; i++) {
            if (first == null) return default; // Handle case where n is larger than list size
            first = first.Next;
        }

        // Move both pointers until first reaches the end
        while (first != null) {
            first = first.Next;
            second = second.Next;
        }

        return second.Value;
    }
}
