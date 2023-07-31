#region struct

//Student s = new Student() { RollNumber = 1, Name = "Vishal"};
//s.Print();

//Console.ReadLine();

//struct Student
//{
//    public int RollNumber { get; set; }
//    public string Name { get; set; }

//    public Student() { }
//    public Student(int rn, string name) { }

//    public void Print()
//    {
//        Console.WriteLine($"Roll Number : {RollNumber} Name: {Name}");
//    }
//}

////class SSCStudent : Student
////{

////}

#endregion struct

#region record

//Student s1 = new Student() { FirstName = "Anil", LastName = "Rathod" };
//Student s2 = new Student() { FirstName = "Anil", LastName = "Rathod" };
//// if (s1 == s2)
//if (s1.Equals(s2))
//{
//    Console.WriteLine("EQUAL");
//}
//else
//{
//    Console.WriteLine("NOT EQUAL");
//}

//Console.WriteLine(s1);
//Console.WriteLine(s2);

//Student s3 = new Student() { FirstName = "Anil", LastName = "Rathod" };
//// s3.FirstName = "Rahul";
//Console.WriteLine($"s3 : First Name : {s3.FirstName} Last Name : {s3.LastName}");

//Student s4 = s3 with { FirstName = "Rahul" };
//Console.WriteLine($"s4 : First Name : {s4.FirstName} Last Name : {s4.LastName}");

//Console.ReadLine();

//// namespace MyNamespace;

//record Student
//{
//    public string FirstName { get; init; }
//    public string LastName { get; init; }
//}

//class Customer
//{
//}

#endregion record

#region string, StringBuilder

//using System.Text;

//Console.WriteLine("*** string ***");

//string tickets = "Kunal";
//Console.WriteLine(tickets);

//tickets = tickets + " Pandurang";
//Console.WriteLine(tickets);

//tickets = tickets + " Ritesh";
//Console.WriteLine(tickets);

//Console.WriteLine("*** StringBuilder ***");

//StringBuilder tickets1 = new StringBuilder("Vishal");
//Console.WriteLine(tickets1);

//tickets1.Append(" Mahesh");
//Console.WriteLine(tickets1);

//tickets1.Append(" Dipak");
//Console.WriteLine(tickets1);

//Console.ReadLine();

#endregion string, StringBuilder

#region datetime

DateTime current1 = DateTime.Now; // current date as well as current time
Console.WriteLine(current1);

DateTime current2 = DateTime.Today; // todays datetime = current date/ 12:00:00 AM
Console.WriteLine(current2);

Console.WriteLine(current1.ToShortDateString());
Console.WriteLine(current1.ToLongDateString());
Console.WriteLine(current1.ToShortTimeString());
Console.WriteLine(current1.ToLongTimeString());

string dob = "09/16/1990";
DateTime dateofBirth = DateTime.Parse(dob);

Console.WriteLine(dateofBirth);
Console.WriteLine(dateofBirth.Year);
Console.WriteLine(dateofBirth.Month);
Console.WriteLine(dateofBirth.ToString("dd MMM yyyy"));
Console.WriteLine(dateofBirth.ToString("dd MMMM yyyy"));

DateTime? hiringDate = null;

Console.ReadLine();

#endregion datetime
