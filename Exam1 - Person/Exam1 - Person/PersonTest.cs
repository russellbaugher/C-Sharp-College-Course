using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor
            Person myPerson = new Person();

            // User Input Name
            Console.WriteLine("Enter Name: ");
            myPerson.Name = Console.ReadLine();

            //User Input Age
            Console.WriteLine("Enter Age: ");
            myPerson.Age = int.Parse(Console.ReadLine());

            //Return # Work Years Left
            myPerson.YTK();
        }
    }
}
