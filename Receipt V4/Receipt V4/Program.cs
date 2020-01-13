using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Declaration
        string[] items = new string[100];
        float[] price = new float[100];
        int[] quantity = new int[100];
        int count = -1, number;
        string input;
        float priceNum, subtotal = 0;
        bool check = false; 

        Console.WriteLine("\n\tScan Items\n");

        // Item Name
        Console.Write("Item name (enter 0 to stop): ");
        
        input = Console.ReadLine();
        if (!Regex.IsMatch(input, @"a-zA-Z0-9&().-_*")) // Digits and Special Chars Only
        { check = true; }
        else
        { check = false; }

        // Catch Invalid Name
        while (check == false)
        {
            Console.WriteLine("Enter Valid Name");
            input = Console.ReadLine();
            if (!Regex.IsMatch(input, @"a-zA-Z0-9&().-_* ")) //Digits and Special Chars
            { check = true; }
            else
            { check = false; }
        }

        do
        {
            count++;
            items[count] = input;

            // Item Price
            Console.Write("Item price: ");
            while (!float.TryParse(Console.ReadLine(), out priceNum)) //Numbers Only
            {
                Console.WriteLine("Enter only numbers 0-9");
                Console.Write("Item price: ");
            }

            price[count] = priceNum;

            Console.Write("Item Quantity: ");
            while (!int.TryParse(Console.ReadLine(), out number)) //Numbers Only
            {
                Console.WriteLine("Enter only numbers 0-9");
                Console.Write("Item Quantity: ");
            }

            quantity[count] = number;
            subtotal += price[count] * quantity[count];
            Console.WriteLine("Item name (enter 0 to stop): ");
            input = Console.ReadLine();

            if (!Regex.IsMatch(input, @"a-zA-Z0-9&().-_* ")) ///Digits and Special Chars
            { check = true; }
            else
            { check = false; }

            // Catch Invalid Name
            while (check == false)
            {
                Console.WriteLine("Enter Valid Name");
                input = Console.ReadLine();

                if (!Regex.IsMatch(input, @"a-zA-Z0-9&().-_* ")) //Digits and Special Chars
                { check = true; }
                else
                { check = false; }
            }
        }
        while (!input.Equals("0"));

        // Display Totals
        Console.WriteLine("\nReceipt\n-------------------------------------------------------------------------" +
                          "\nItem\t\tPrice\t\tQuantity\t\tSubTotal" +
                          "\n-------------------------------------------------------------------------");
        for (int i = 0; i <= count; i++)
        {
            Console.WriteLine(items[i] + "\t\t" + price[i] + "\t\t" + quantity[i] + "\t\t\t" + (price[i] * quantity[i]));
        }
        Console.WriteLine("-------------------------------------------------------------------------" +
                          "\nSubtotal: \t" + subtotal +
                          "\nTax (6.5%): \t" + Math.Round(subtotal * 0.065, 2) +
                          "\nTotal: \t\t" + Math.Round(subtotal + (subtotal * 0.065), 2) +
                          "\n-------------------------------------------------------------------------");
        Console.ReadKey();
    }
}
