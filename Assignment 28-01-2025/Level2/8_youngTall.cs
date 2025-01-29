using System;
public class FriendsInfo{
    public int FindYoungest(int[] ages){
        int youngest = ages[0];
        for (int i = 1; i < ages.Length; i++){
            if (ages[i] < youngest){
                youngest = ages[i];
            }
        }
        return youngest;
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
        int[] ages = new int[3];
        int[] heights = new int[3];
        FriendsInfo info = new FriendsInfo();

        for (int i = 0; i < 3; i++){
            Console.Write("Enter age of friend " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());
            Console.Write("Enter height of friend " + (i + 1) + ": ");
            heights[i] = int.Parse(Console.ReadLine());
        }
        
        int youngest = info.FindYoungest(ages);
        int tallest = info.FindTallest(heights);

        Console.WriteLine("The youngest friend's age is " + youngest + ".");
        Console.WriteLine("The tallest friend's height is " + tallest + ".");
    }
}
