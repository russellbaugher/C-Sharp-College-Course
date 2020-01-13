using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7_Class_Constructors
{
    public class Student
    {
        // Data Members //
        public static int Count; // Store total # of students
        private static readonly Random rnd = new Random(); // Randomly assemble student ID
        private string firstName;
        private string lastName;
        private int sID;

        // Public Properties - (Read-Only Auto-Implemented) //
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }

        // C1 - Parameterized Constructor - Called if (if 3 params provided) //
        public Student(string first, string last, int id) // Initialize Student
        {
            FirstName = first;
            LastName = last;
            StudentID = id;
            ++Count;
        }

        // C2 - Constructor for Handling Null Arguments (if 0,1,2 params provided) //
        public Student(string first = "", string last = "")
        {
            FirstName = first;
            LastName = last;
            StudentID = rnd.Next(1000, 9999);
            ++Count;
        }
    } //End Student
}
