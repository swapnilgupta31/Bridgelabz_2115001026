using System;
public class StudentVoteChecker{
    public bool CanStudentVote(int age){
        if (age < 0){
            return false;
        }
        if (age >= 18){
            return true;
        }
        return false;
    }
    public static void Main(string[] args){
        int[] ages = new int[10];
        StudentVoteChecker checker = new StudentVoteChecker();

        for (int i = 0; i < 10; i++){
            Console.Write("Enter age of student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());
            bool canVote = checker.CanStudentVote(ages[i]);
            if (canVote){
                Console.WriteLine("Student " + (i + 1) + " can vote.");
            }
            else{
                Console.WriteLine("Student " + (i + 1) + " cannot vote.");
            }
        }
    }
}
