using System;
using System.Collections;
using System.Collections.Generic;

class ReverseList {
    static void Main() {
        // ArrayList Example
        ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
        ReverseArrayList(arrayList);
        Console.Write("Reversed ArrayList: ");
        PrintArrayList(arrayList);

        // LinkedList Example
        LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        LinkedList<int> reversedList = ReverseLinkedList(linkedList);
        Console.Write("Reversed LinkedList: ");
        PrintLinkedList(reversedList);
    }

    // Method to reverse an ArrayList
    static void ReverseArrayList(ArrayList list) {
        int left = 0, right = list.Count - 1;
        while (left < right) {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }

    // Method to reverse a LinkedList
    static LinkedList<int> ReverseLinkedList(LinkedList<int> list) {
        LinkedList<int> reversedList = new LinkedList<int>();
        foreach (var item in list) {
            reversedList.AddFirst(item); // Adding at the beginning reverses the order
        }
        return reversedList;
    }

    // Method to print ArrayList properly
    static void PrintArrayList(ArrayList list) {
        foreach (var item in list) {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    // Method to print LinkedList properly
    static void PrintLinkedList(LinkedList<int> list) {
        foreach (var item in list) {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
