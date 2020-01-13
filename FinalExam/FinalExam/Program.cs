using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main()
        {
            // Course Objects
            Course course1 = new Course("CTS1851", "Internet Web Foundation");
            Course course2 = new Course("CGS2820", "Web Programming");
            Course course3 = new Course("CGS2821", "Advanced Web Programming");
            Course course4 = new Course("COP2361", "C# Programming");

            // Dictionary Objects
            Dictionary<string, string> courses = new Dictionary<string, string>();
            courses.Add(course1.CID, course1.CNAME);
            courses.Add(course2.CID, course2.CNAME);
            courses.Add(course3.CID, course3.CNAME);
            courses.Add(course4.CID, course4.CNAME);

            // Display IDs and Names
            foreach (var pair in courses)
            {
                Console.WriteLine($"{pair.Key}, {pair.Value}");
            }
            Console.ReadLine();
        }
    } // End Program

    public class Course
    {
        // Set ID and Name Properties 
        string ID;

        public string CID
        {
            get { return this.ID; }
            set { this.ID = value; }
        }

        string Name;

        public string CNAME
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        // Constructor 
        public Course(string courseId, string courseName)
        {
            ID = courseId;
            Name = courseName;
        }
    } // End Course
}
