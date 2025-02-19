using System;
using System.Collections.Generic;

class RotateList {
    static void Main() {
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        int rotateBy = 2;
        Rotate(numbers, rotateBy);

        Console.WriteLine("Rotated List: " + string.Join(", ", numbers));
    }

    static void Rotate(List<int> list, int positions) {
        int count = list.Count;
        positions = positions % count; // Ensure rotation is within bounds

        List<int> temp = new List<int>(list.GetRange(0, positions)); // Store first 'positions' elements
        list.RemoveRange(0, positions); // Remove them from the list
        list.AddRange(temp); // Append them at the end
    }
}
