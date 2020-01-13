using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal count;
            decimal subtotal;
            decimal tax;
            decimal total;
            decimal price;

            //Initialization Phase
            subtotal = 0;
            count = 0;
            tax = 0.065M;

            //Processing Phase
            Console.WriteLine("{0,30}", "Your Receipt"); //30 spaces to right
            price = Convert.ToDecimal(Console.ReadLine());

            while (price != -1)
            {
                subtotal = subtotal + price; //add price to total
                count = count + 1; //increment counter

                //Prompt for and read next price from user
                price = Convert.ToDecimal(Console.ReadLine());
            }
            tax = tax * subtotal;
            total = subtotal + tax;

            //Termination Phase
            if (count != 0)
            {
                //Calc sum of all prices entered
                //sum = total;///////////////////////////////////////

                //Display total
                Console.WriteLine("\nItems: {0,5} \nSubtotal: {1,10:C} \nTax (6.5%): {2:C} \nTotal: {3:C}",
                    count, subtotal, tax, total);
            }
            else //no prices entered, output error message
                Console.WriteLine("No prices were entered");
        }
    }
}
