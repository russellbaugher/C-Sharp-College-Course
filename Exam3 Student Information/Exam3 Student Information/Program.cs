using System;

//Student.cs
public abstract class Student
{
    public string firstName;
    public string lastName;
    public string studentID;
    public Student(string first, string last, string ID)
    {
        firstName = first;
        lastName = last;
        studentID = ID;
    }
    public string FirstName
    {
        get { return firstName; }
    }
    public string LastName
    {
        get { return lastName; }
    }
    public string StudentID
    {
        get { return studentID; }
    }
    public abstract string ImportantThing();
}

//ElementarySchoolStudent.cs
class ElementarySchoolStudent : Student, IMathClass
{
    public ElementarySchoolStudent(string first, string last, string ID)
    : base(first, last, ID)
    { }
    public override string ImportantThing() { return "n exciting farm field trip"; }
    public string Math() { return "Basic Math"; }
    public override string ToString()
    {
        return $"My name is {firstName} {lastName}, I am an elementary school student. " +
               $"I have a{ImportantThing()}. I will learn {Math()}.\n";
    }
}

//MiddleSchoolStudent.cs
class MiddleSchoolStudent : Student, IMathClass
{
    public MiddleSchoolStudent(string first, string last, string ID) : base(first, last, ID)
    { }
    public override string ImportantThing() { return "Summer Camp"; }
    public string Math() { return "Geometry"; }
    public override string ToString()
    {
        return $"My name is {firstName} {lastName}, I am a middle school student. " +
               $"I will go to {ImportantThing()}. I will learn {Math()}.\n";
    }
}

//HighSchoolStudent.cs
class HighSchoolStudent : Student, IMathClass
{
    public HighSchoolStudent(string first, string last, string ID)
    : base(first, last, ID)
    { }
    public override string ImportantThing() { return "SAT exam"; }
    public string Math() { return "Basic Algebra"; }
    public override string ToString()
    {
        return $"My name is {firstName} {lastName}, I am a high school student. " +
               $"I will take the {ImportantThing()}. I will learn {Math()}.\n";
    }
}

//CollegeStudent.cs
class CollegeStudent : Student, IMathClass
{
    public CollegeStudent(string first, string last, string ID)
    : base(first, last, ID)
    { }
    public override string ImportantThing() { return "Major.."; }
    public string Math() { return "Advanced Algebra"; }
    public override string ToString()
    {
        return $"My name is {firstName} {lastName}, I am a college student. " +
               $"I have a {ImportantThing()}. I will learn {Math()}.\n";
    }
}

//IMathClass.cs
public interface IMathClass
{
    string Math();
}

//Program.cs
class Program 
{
    static void Main(string[] args)
    {
        Student[] s = new Student[4];

        s[0] = new ElementarySchoolStudent("John", "Smith", "M11");
        s[1] = new MiddleSchoolStudent("William", "Alexander", "M11");
        s[2] = new HighSchoolStudent("Matthew", "Grassfield", "M11");
        s[3] = new CollegeStudent("Bill", "Hancock", "M11");

        foreach (var i in s)
        {
            Console.WriteLine(i.ToString());
        }
    }
}