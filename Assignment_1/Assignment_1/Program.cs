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
            // Heading
            Console.WriteLine("XYZ Super Market Receipt");
            Console.WriteLine("**************************************************");
            Console.WriteLine("");

            // Input Item Prices
            Console.Write($"                             apple:      $");
            decimal apple = Convert.ToDecimal(Console.ReadLine());
            Console.Write($"                             orange:     $");
            decimal orange = Convert.ToDecimal(Console.ReadLine());
            Console.Write($"                             watermelon: $");
            decimal water = Convert.ToDecimal(Console.ReadLine());

            // Dividing Line
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(""); Console.WriteLine("");

            // Output Subtotal, Tax, Total
            decimal subtotal = apple + orange + water;
            Console.WriteLine("                             " +
                "Subtotal:   ${0}", String.Format("{0:0.00}", subtotal));

            decimal tax = 0.065M * subtotal;
            Console.WriteLine("                             " +
                "Tax:        ${0}", String.Format("{0:0.00}", tax));

            decimal total = subtotal + tax;
            Console.WriteLine("                             " +
                "Total:      ${0}", String.Format("{0:0.00}", total));
            
            // Footer
            Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine("                   Thank you for shopping with us!");
            Console.WriteLine(""); Console.WriteLine("");
        }
    }
}
