using System;
class TrignometricFunctions{
    public static double[] calculateTrigonometricFunctions(double angle){
        //convert angle to randians 
        double radians = Math.PI * angle /180 ;

        //calculate sine , cosine and tangent 
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        //return the results in an array 
        return new double[] {sine , cosine , tangent};
    }
    static void Main(string[] args){
        Console.WriteLine("Enter the angle in degrees: ");
        double angle = double.Parse(Console.ReadLine());

        //call the method 
        double[] results = calculateTrigonometricFunctions(angle);

        Console.WriteLine("Trigonometric Functions for angle: " + angle + " degrees");
        Console.WriteLine("Sine: " + results[0]);
        Console.WriteLine("Cosine: " + results[1]);
        Console.WriteLine("Tangent: " + results[2]);
    }
}
