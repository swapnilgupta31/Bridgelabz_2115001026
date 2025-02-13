using System;
using System.Collections.Generic;

class StockSpan {
    public static void CalculateStockSpan(int[] prices) {
        int n = prices.Length;
        int[] spans = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++) {
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i]) {
                stack.Pop();
            }
            
            spans[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
            stack.Push(i);
        }

        Console.WriteLine("Stock Spans: " + string.Join(" ", spans));
    }

    static void Main() {
        int[] prices = {100, 80, 60, 70, 60, 75, 85};
        CalculateStockSpan(prices);
    }
}
