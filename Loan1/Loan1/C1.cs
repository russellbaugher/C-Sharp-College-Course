using System;

// Define Members and Methods to Calc Interest
public class C1 : IMyInterface
{
    // Private Data Members
    private double loanAmnout = 0.0;
    private double years = 0.0;
    private double interests = 0.0;
    private double interestRate = 0.0;

    // Constructor to Initialize/Assign Local Variables
    public C1(double loanAmount, double years, double interestRate)
    {
        // Assign Passed Input to Private Variables
        this.loanAmnout = loanAmount;
        this.years = years; 
        this.interestRate = interestRate; 
    }

    // Return Total Interest w/ Exception Handling
    public double PayInterests()
    {
        try
        {
            interests = loanAmnout * interestRate * years;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception occured: " + ex.StackTrace);
        }
        return interests;
    }

    // Return String Message
    public string iMessage()
    {
        return ("Be Ready!");
    }
} // End C1
