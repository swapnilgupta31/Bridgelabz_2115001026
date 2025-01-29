using System;
public class FootballTeam{
    public int FindSum(int[] heights){
        int sum = 0;
        for (int i = 0; i < heights.Length; i++){
            sum += heights[i];
        }
        return sum;
    }
    public double FindMean(int[] heights){
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }
    public int FindShortest(int[] heights){
        int shortest = heights[0];
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] < shortest){
                shortest = heights[i];
            }
        }
        return shortest;
    }
    public int FindTallest(int[] heights){
        int tallest = heights[0];
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > tallest){
                tallest = heights[i];
            }
        }
        return tallest;
    }
    public static void Main(string[] args){
        Random rand = new Random();
        int[] heights = new int[11];
        FootballTeam team = new FootballTeam();
        
        // Generate 3-digit random heights for each player (between 150 and 250 cm)
        for (int i = 0; i < 11; i++){
            heights[i] = rand.Next(150, 251);
        }
        
        // Find the sum, mean, shortest, and tallest
        int sum = team.FindSum(heights);
        double mean = team.FindMean(heights);
        int shortest = team.FindShortest(heights);
        int tallest = team.FindTallest(heights);
        
        // Display the results
        Console.WriteLine("Heights of players: ");
        foreach (int height in heights){
            Console.Write(height + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Sum of heights: " + sum);
        Console.WriteLine("Mean height: " + mean);
        Console.WriteLine("Shortest height: " + shortest);
        Console.WriteLine("Tallest height: " + tallest);
    }
}
