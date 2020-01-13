using System;

namespace Assignment2_Calculator1
{
    public class Calculator
    {
        //Declare op1
        private readonly double firstOperand;
        public double FirstOperand
        { get; set; }

        //Declare op2
        private readonly double secondOperand;
        public double SecondOperand
        { get; set; }

        //Declare Result
        private double result;
        public double Result
        { get; set; }

        //Add op1 + op2
        public void Addition()
        {
            double Result = FirstOperand + SecondOperand;
            Console.WriteLine($"Sum: {Result}");
        }
    }
}
