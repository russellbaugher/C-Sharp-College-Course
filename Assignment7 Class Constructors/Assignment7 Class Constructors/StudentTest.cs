using System;
using System.Collections.Generic;

namespace Assignment7_Class_Constructors
{
    public class StudentTest
    {
        static void Main(string[] args)
        {
            // Create Student List
            List<Student> myList = new List<Student>();

            // Create s1 Object
            Student s1 = new Student();
            s1.FirstName = "John";
            s1.LastName = "Smith";
            s1.StudentID = 2560;
            myList.Add(s1);

            // Add Objects to List (s2,s3,s4,s5)
            Student s2 = new Student("Peter"); // 1 param, call C2
            myList.Add(s2);

            Student s3 = new Student("Morgan", "Simmons"); // 2 params, call C2
            myList.Add(s3);

            Student s4 = new Student("James", "Walters"); // 2 params, call C2
            myList.Add(s4);

            Student s5 = new Student("Linda", "Scott", 1005); // 3 params, call C1
            myList.Add(s5);

            // Output to User //
            Console.WriteLine("\nTotal Students: {0}", Student.Count);

            // Iterate Through List & Print //
            foreach (Student s in myList)
            {
                Console.WriteLine("Student Name: {0} {1} \tStudent ID: {2}",                           
                                  s.FirstName, s.LastName, s.StudentID);
            }
        } //End Main
    } //End StudentTest
}
