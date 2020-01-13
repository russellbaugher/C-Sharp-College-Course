using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment6_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create List of Strings
            List<string> items = new List<string>();

            // Read Input and Add to List of Strings 
            Console.Write("Enter First Name: ");
            string firstName = (Console.ReadLine());
            items.Add(firstName);
            Console.Write("Enter Last Name:  ");           
            string lastName = (Console.ReadLine());
            items.Add(lastName);
            Console.Write("Enter Street:     ");
            string street = (Console.ReadLine());
            items.Add(street);
            Console.Write("Enter City:       ");
            string city = (Console.ReadLine());
            items.Add(city);
            Console.Write("Enter State:      ");
            string state = (Console.ReadLine());
            items.Add(state);
            Console.Write("Enter Zip:        ");
            string zip = (Console.ReadLine()); 
            items.Add(zip);

            // Select Clause, Call Capitalization Method
            var capitalizedItems =
                from item in items
                let uppercaseString = UppercaseWords(item)
                select uppercaseString;

            Console.WriteLine("\n\nCostumer’s information: ");

            // Display List 
            foreach (var item in capitalizedItems)
            { Console.WriteLine("{0} ", item); }

            Console.WriteLine("\n");

        } //Main

        //Capitalize 1st Letter of Strings Separated by ' ' 
        public static string UppercaseWords(string value)
        {
            char[] array = value.ToCharArray();

            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        } //UppercaseWords
    } //Program
}