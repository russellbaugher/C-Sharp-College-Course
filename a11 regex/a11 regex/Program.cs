using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        //Declaration
        string name, num;
        bool attempt = false;

        //Prompt Name Input
        Console.Write("Enter Name on Card: ");
        while (!attempt)
        {
            name = Console.ReadLine();
            Match match = Regex.Match(name, @"\b[a-zA-Z]{2,15}\s[a-zA-Z]{2,15}\b", RegexOptions.IgnoreCase);

            // Assign Match Status to Attempt
            attempt = match.Success;
            if (!attempt)
                Console.Write("Enter Name on Card (letters only, both first and last name): ");
        }

        attempt = false;
        // Prompt Number
        Console.Write("\nEnter Credit Card Number: ");
        while (!attempt)
        {
            num = Console.ReadLine();
            Match match = Regex.Match(num, @"^[0-9]{12,19}$", RegexOptions.IgnoreCase);

            // Assign Match Status to Attempt
            attempt = match.Success;
            if (!attempt)
                Console.Write("Enter Credit Card Number: (12 to 19 digits): ");
        }
        // Success Message
        Console.WriteLine("\nThank you for your Order\n");
        Console.ReadLine();
    }
}