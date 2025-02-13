using System;
using System.Collections.Generic;

class PairSum {
    public static void FindPairWithSum(int[] arr, int target) {
        HashSet<int> seen = new HashSet<int>();

        for (int i = 0; i < arr.Length; i++) {
            int required = target - arr[i]; // Find required number

            if (seen.Contains(required)) { // Check if required number is in the set
                Console.WriteLine("Pair found: (" + required + ", " + arr[i] + ")");
                return;
            }

            seen.Add(arr[i]); // Store current number
        }

        Console.WriteLine("No pair found.");
    }

    static void Main() {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;
        FindPairWithSum(arr, target);
    }
}
