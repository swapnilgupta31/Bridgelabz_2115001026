using System;
using System.Collections.Generic;

class ZeroSumSubarrays {
    public static void FindZeroSumSubarrays(int[] arr) {
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int sum = 0;

        // Store zero sum at index -1 for subarrays starting at index 0
        map[0] = new List<int> { -1 };

        for (int i = 0; i < arr.Length; i++) {
            sum += arr[i]; // Compute cumulative sum

            // If sum already exists in map, subarrays exist
            if (map.ContainsKey(sum)) {
                foreach (int start in map[sum]) {
                    Console.WriteLine("Subarray found from index " + (start + 1) + " to " + i);
                }
            }

            // Store the current sum in the map
            if (!map.ContainsKey(sum)) {
                map[sum] = new List<int>();
            }
            map[sum].Add(i);
        }
    }

    static void Main() {
        int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
        FindZeroSumSubarrays(arr);
    }
}
