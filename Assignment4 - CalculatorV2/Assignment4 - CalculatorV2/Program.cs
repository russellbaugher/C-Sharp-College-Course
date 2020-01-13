using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        // Variables
        double firstOperand;
        double secondOperand;
        double answer;
        string oper;

        // Heading
        Console.WriteLine("\tConsole Calculator\n");

        // First Number Prompt & Capture
        Console.Write("\tEnter first operand:   ");
        firstOperand = Convert.ToDouble(Console.ReadLine());

        // Operator (+-*/) Prompt & Capture
        Console.Write("\tOperator (+, -, *, /): ");
        oper = Console.ReadLine();

        // Second Number Prompt & Capture
        Console.Write("\tEnter second operand:  ");
        secondOperand = Convert.ToDouble(Console.ReadLine());

        // Processing
        switch (oper)
        {
            case "+":
                answer = Addition(firstOperand, secondOperand);
                Console.WriteLine($"\tAddition: {firstOperand} + {secondOperand} = {answer}\n");
                break;
            case "-":
                answer = Subtraction(firstOperand, secondOperand);
                Console.WriteLine($"\tSubtraction: {firstOperand} - {secondOperand} = {answer}\n");
                break;
            case "*":
                answer = Multiplication(firstOperand, secondOperand);
                Console.WriteLine($"\tMultiplication: {firstOperand} * {secondOperand} = {answer}\n");
                break;
            case "/":
                answer = Division(firstOperand, secondOperand);
                Console.WriteLine($"\tDivision: {firstOperand} / {secondOperand} = {answer}\n");
                break;
            default:
                Console.WriteLine("\tYou did not enter a correct operator, no calculation done.\n");
                break;
        }
    } //Main

    // Operation Methods
    public static double Addition(double x, double y) => x + y;
    public static double Subtraction(double x, double y) => x - y;
    public static double Multiplication(double x, double y) => x * y;
    public static double Division(double x, double y) => x / y;

} //Calculator




