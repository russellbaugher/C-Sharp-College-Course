using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Person
{
    public class Person
    {
        private string name;
        public string Name
        { get; set; }

        private int age;
        public int Age
        { get; set; }
                //if (value >= 65)
                //Console.WriteLine("Retire!");

        private int yearstowork;
        public int YearsToWork
        { get; set; }

        //Subtract Age from 65
        public void YTK()
        {
            int YearsToWork = 65 - Age;
            Console.WriteLine($"You will work: {YearsToWork} years before you retire.");
        }
    }
        
}





//Initialized variables
//private string name = "";
//private int age = 0;
//private int YearsToWork = 0;