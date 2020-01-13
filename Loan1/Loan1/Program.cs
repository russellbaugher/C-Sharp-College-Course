using System;

class Program
{
    static void Main()
    {
        double loanAmount = 0.0, years = 0.0, interestRate = 0.0, totalInterest = 0.0;

        // User Input, Assign Variable Values
        Console.WriteLine("Please enter loan amount: ");
        loanAmount = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("Please enter years: ");
        years = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("Please enter interest rate: ");
        interestRate = Convert.ToDouble(Console.ReadLine()); 

        // Call Class Constructor, Pass User Input as Parameter
        C1 c1 = new C1(loanAmount, years, interestRate);

        // Call Method with Object
        totalInterest = c1.PayInterests(); 

        // Write Outputs to Console
        Console.WriteLine($"Total pay interest amount is: {totalInterest}");
        Console.WriteLine(c1.iMessage());
    } 
}