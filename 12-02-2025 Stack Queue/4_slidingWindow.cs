using System;
using System.Collections.Generic;

class SlidingWindowMax {
    public static void FindMaxInSlidingWindow(int[] nums, int k) {
        if (nums.Length == 0 || k <= 0) return;

        List<int> result = new List<int>();
        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < nums.Length; i++) {
            // Remove elements that are out of this window
            if (deque.Count > 0 && deque.First.Value < i - k + 1) {
                deque.RemoveFirst();
            }

            // Remove elements from the back if they are smaller than current element
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i]) {
                deque.RemoveLast();
            }

            // Add current element at the end
            deque.AddLast(i);

            // Add maximum of current window to result (starting from index k-1)
            if (i >= k - 1) {
                result.Add(nums[deque.First.Value]);
            }
        }

        Console.WriteLine("Sliding Window Maximums: " + string.Join(" ", result));
    }

    static void Main() {
        int[] nums = {1, 3, -1, -3, 5, 3, 6, 7};
        int k = 3;
        FindMaxInSlidingWindow(nums, k);
    }
}
