using System;
using System.Collections.Generic;

class LongestConsecutiveSequence {
    public static int FindLongestSequence(int[] arr) {
        HashSet<int> numSet = new HashSet<int>(arr);
        int maxLength = 0;

        foreach (int num in arr) {
            if (!numSet.Contains(num - 1)) { // Start of a new sequence
                int currentNum = num;
                int count = 1;

                while (numSet.Contains(currentNum + 1)) { // Count consecutive numbers
                    currentNum++;
                    count++;
                }

                maxLength = Math.Max(maxLength, count);
            }
        }
        return maxLength;
    }

    static void Main() {
        int[] arr = { 100, 4, 200, 1, 3, 2 };
        Console.WriteLine("Longest Consecutive Sequence Length: " + FindLongestSequence(arr));
    }
}
