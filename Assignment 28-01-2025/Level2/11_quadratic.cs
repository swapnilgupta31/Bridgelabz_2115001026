using System;
public class Quadratic{
    public double[] FindRoots(double a, double b, double c){
        double delta = Math.Pow(b, 2) - 4 * a * c; // Delta formula
        if (delta > 0){ // Two real roots
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return new double[] { root1, root2 };
        }
        else if (delta == 0){ // One real root
            double root = -b / (2 * a);
            return new double[] { root };
        }
        else{ // No real roots
            return new double[0]; // Empty array for no real roots
        }
    }
    public static void Main(string[] args){
        double a, b, c;
        Quadratic quadratic = new Quadratic();
        // Take input for a, b, and c
        Console.Write("Enter the value of a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Enter the value of b: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("Enter the value of c: ");
        c = double.Parse(Console.ReadLine());
        // Find the roots using the method
        double[] roots = quadratic.FindRoots(a, b, c);
        // Output the results
        if (roots.Length == 2){
            Console.WriteLine("The roots are: " + roots[0] + " and " + roots[1]);
        }
        else if (roots.Length == 1){
            Console.WriteLine("The root is: " + roots[0]);
        }
        else{
            Console.WriteLine("There are no real roots.");
        }
    }
}
