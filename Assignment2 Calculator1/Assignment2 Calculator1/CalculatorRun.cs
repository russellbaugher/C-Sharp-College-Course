using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Calculator1
{
    class CalculatorRun
    {
        static void Main(string[] args)
        {
            //Constructor
            Calculator MyCalc = new Calculator();

            Console.WriteLine("Addition Calculator");

            //User Input Two Operands
            Console.WriteLine("enter first number: ");
            MyCalc.FirstOperand = double.Parse(Console.ReadLine());
            Console.WriteLine("enter second number: ");
            MyCalc.SecondOperand = double.Parse(Console.ReadLine());

            //Return Sum
            MyCalc.Addition();
        }
    }
}
