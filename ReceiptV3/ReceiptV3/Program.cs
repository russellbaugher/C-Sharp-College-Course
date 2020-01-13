using System;

namespace ReceiptV3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] items = new string[100, 4];
            string input;
            int count = 0;
            decimal subtotal = 0;
            decimal tax = 0.065M;
            decimal total = 0;

            Console.WriteLine("\n\tScan Items Now\n");
            // Prompt User Input 
            Console.Write("Item name(enter 0 to stop): ");
            do
            {
                count++;
                // Name [0]
                input = Console.ReadLine();
                if (input == "0")
                {
                    break;
                }
                items[count, 0] = input;

                // Price [1]
                Console.Write("Enter price : ");
                input = Console.ReadLine();
                items[count, 1] = input;

                // Quantity [2]
                Console.Write("Quantity : ");
                input = Console.ReadLine();
                items[count, 2] = input;
                // Name 
                Console.Write("\nItem name(enter 0 to stop): ");

                //Subtotal Calc [3]
                decimal price = Convert.ToDecimal(items[count, 1]) * Convert.ToDecimal(items[count, 2]);
                items[count, 3] = price.ToString();

                subtotal += price; //for output string at end         
            }
            while (input != "0"); //this may not be ever used bc of if-break on line 25

            tax = tax * subtotal;
            count = count - 1; //+1 compensate for bug
            total = subtotal + tax;

            //Results Header
            Console.WriteLine("\n\tYour Receipt\n" + "-----------------------------------");

            Console.Write("Item\tPrice\tQuantity Subtotal");

            //Display Item Results
            for (int i = 0; i <= count; i++)
                Console.WriteLine(items[i, 0] + "\t" + items[i, 1] + "\t" + items[i, 2] + "\t " + items[i, 3]);

            //Output String
            Console.Write(
                "-----------------------------------" +
                "\n{0} Items total" +
                "\nSubtotal: \t\t {1:C} " +
                "\nTax (6.5%): \t\t {2:C}" +
                "\nTotal: \t\t\t {3:C}\n", +
                 count, subtotal, tax, total
                 );
            Console.WriteLine("-----------------------------------");
        }
    }
}
