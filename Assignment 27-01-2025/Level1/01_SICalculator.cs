using System ; 
class SICalculator{
    static double SimpleInterestMethod(double principal , double rate , double time){
        return (principal * rate * time)/100;
    }
    static void Main(string [] args){
        //take user input for principle , rate and Time 
        Console.WriteLine("Enter the Principle Amount :") ;
        double principal = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Rate of Interest (in %) :") ;
        double interest = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the number of Years :") ;
        double time = double.Parse(Console.ReadLine());

        //calculate simple interest using method 
        double simpleInterest = SimpleInterestMethod(principal,interest , time);

        //display the result 
        Console.WriteLine("The Simple Interest is " + simpleInterest + " for principal "+ principal + " , Rate of Interest "+ interest + " , and TIme " + time+ " years.");
        
    }
}