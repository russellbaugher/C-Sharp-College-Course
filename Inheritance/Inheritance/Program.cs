using System;

namespace Inheritance
{
    class DSC
    {
        // SchoolName
        private string schoolName = "Daytona State College";
        public string SchoolName() // Constructor Property Get-Set
        {
            return schoolName;
        }
        // Address
        public virtual string ShowAddress()  // Overwrite When Needed
        {
            return "1200 W. International Speedway Blvd., Daytona Beach, Florida 32114 ";
        }
    } // End DSC //

    class Campus : DSC // Campus Inherits DSC
    {
        // Campus
        private string campusName { get; set; }
        public Campus(string cName) // Constructor Property Get-Set
        {
            campusName = cName;
        }
        // Address
        public override string ShowAddress()
        {
            return "1770 Williamson Blvd., Daytona Beach, Florida 32117";
        }
        //Department
        public string Departments()
        {
            return "Computer Science Department, Emergency Care Department, Police Academy";
        }
        // Output String
        public override string ToString()
        {
            return $"\n{SchoolName()} {campusName} is located at {ShowAddress()}. It has a {Departments()}. \n";
        }
    } // End Campus : DSC //

    class Program
    {
        static void Main()
        {
            Campus atc = new Campus("Advanced Technology College");
            // Return ToString with Campus atc
            Console.WriteLine(atc.ToString());
        }
    } // End Program //
}