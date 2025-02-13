using System;
using System.Collections.Generic;

class TwoSumSolution {
    public static int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i]; // Find the required pair

            if (numIndices.ContainsKey(complement)) { // Check if complement exists
                return new int[] { numIndices[complement], i }; // Return indices
            }

            numIndices[nums[i]] = i; // Store current number's index
        }

        return new int[] {}; // Return empty if no pair found
    }

    static void Main() {
        int[] nums = {2, 7, 11, 15};
        int target = 9;

        int[] result = TwoSum(nums, target);
        
        if (result.Length > 0)
            Console.WriteLine("Indices: [" + result[0] + ", " + result[1] + "]");
        else
            Console.WriteLine("No valid pair found.");
    }
}
