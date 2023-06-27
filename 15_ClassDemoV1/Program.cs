using System.Globalization;
using System.Net.Http.Headers;

class Program
{
    static void Main()
    {
        Console.WriteLine("Main Starts Here..");

        Student.CompanyName = "VHaaSh Technologies";

        // Student.Print();

        // object / instance
        Student s1 = new Student();
        
        s1.PrintDetails();

        s1.RollNumber = 101;
        s1.FirstName = "Ramesh";
        s1.LastName = "Yadav";
        s1.Email = "ramesh@gmail.com";

        s1.PrintDetails();

        Student s2 = new Student();
        s2.RollNumber = 102;
        s2.FirstName = "Ritesh";
        s2.LastName = "Jadhav";
        s2.Email = "ritesh@gmail.com";

        s2.PrintDetails();

        Student s3 = new Student();
        s3.Initialize(103, "Paresh", "Desale", "paresh@gmail.com");
        s3.PrintDetails();

        // object initializer syntax
        Student s4 = new Student()
        {
            RollNumber = 104,
            FirstName = "Ashish",
            LastName = "Kandharkar",
            Email = "ashish@gmail.com"
        };

        s4.PrintDetails();
        
        Console.WriteLine("------------------------------------------");
        Student s5 = s4;
        s5.FirstName = "Akash";
        // s5.CompanyName = "VHaaSh"; // we cannot access static member using object
        Student.CompanyName = "VHaaSh";
        s5.PrintDetails();

        s4.PrintDetails();

        s1 = s5;
        s1.PrintDetails();

        Console.WriteLine("------------------------------------------");

        //Customer c1 = new Customer(); // Customer is a static class
        //Customer c2 = new Customer(); // Customer is a static class

        Trainer t1 = new Trainer() { Name = "Usha", ExperienceInYear = 3};
        t1.PrintTrainerDetails();

        Console.WriteLine("Main Ends Here..");

        Console.ReadLine();
    }
}

public class Student
{
    // fields

    // instance members / non static members
    public int RollNumber;
    public string FirstName;
    public string LastName;
    public string Email;

    // static member
    public static string CompanyName = "V#";

    public void Initialize(int rn, string fn, string ln, string email)
    {
        RollNumber = rn;
        FirstName = fn;
        LastName = ln;
        Email = email;

        // PrintDetails(); // direct access to another members inside a class
    }

    public void PrintDetails() // non static/ instance method
    {
        Console.WriteLine($"RollNumber : {RollNumber}" +
            $" Name : {FirstName} {LastName}" +
            $" Email : {Email} Company Name : {CompanyName}");
    }

    public static void Print() // static method
    {
        Console.WriteLine(CompanyName);
        // Console.WriteLine(RollNumber); // not accessible
        // PrintDetails(); // not accessible

        Student s = new Student();
        s.RollNumber = 100; // we can access due to object
        s.FirstName = "Vishal"; // we can access due to object
        s.PrintDetails(); // we can access due to object
    }
}

public static class Customer
{
    public static string ServiceName;

    public static void Print()
    {
        Console.WriteLine("Customer print() Method");
    }
}