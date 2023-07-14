#region object is base for all types

//Student s1 = new Student();
//// s1.GetType();
//// s1.ToString();
//// s1.Equals()
//// s1.GetHashCode();

//Customer c1 = new Customer();
//int i = 10;

//object o = 10; // int value
//o = "Vishal"; // string value
//o = '$'; // char value
//o = true; // boolean value
//o = new Student(); // Student object
//o = new Customer(); // Customer object

#endregion object is base for all types


#region GetType()

//using VHaaSh;

//Student s1 = new Student();
//// to retrieve type information 
//Console.WriteLine(typeof(Student));
//Console.WriteLine(s1.GetType());

//Type t = s1.GetType();
//Console.WriteLine(t.Name);
//Console.WriteLine(t.Namespace);
//Console.WriteLine(t.FullName);

////int i = 10;
////Console.WriteLine(i.GetType());

#endregion GetType()

#region ToString() method

//int i = 10, j = 20;
//Console.WriteLine(i + j);
//Console.WriteLine(i.ToString() + j.ToString());

//Customer c1 = new Customer() { FirstName = "Anil", LastName = "Rathod"};
//Console.WriteLine(c1.ToString()); // Anil Rathod

//Customer c2 = new Customer() { FirstName = "Ajay", LastName = "Ade" };
//Console.WriteLine(c2.ToString()); // Ajay Ade


#endregion ToString() method

#region Equals() method

////int i = 10;
////int j = 10;
////if(i.Equals(j))
////{
////    Console.WriteLine("i & j are EQUAL");
////}
////else
////{
////    Console.WriteLine("i & j are NOT EQUAL");
////}

//Customer c1 = new Customer() { FirstName = "Rahul", LastName = "Rathod" };
//// Customer c2 = c1;
//Customer c2 = new Customer() { FirstName = "Rahul", LastName = "Rathod" };

//if (c1.Equals(c2))
//{
//    Console.WriteLine("c1 & c2 are EQUAL");
//}
//else
//{
//    Console.WriteLine("c1 & c2 are NOT EQUAL");
//}


#endregion Equals() method

#region GetHashCode() method

int i = 10;
int j = 10;
Console.WriteLine($"i hash code : {i.GetHashCode()}");
Console.WriteLine($"j hash code : {j.GetHashCode()}");
if (i.GetHashCode() == j.GetHashCode())
{
    Console.WriteLine("i & j hash code are equal");
}

string s = "Vishal";
string s1 = "Vishal";
string s2 = "Vivek";
Console.WriteLine($"s hash code {s} : {s.GetHashCode()}");
Console.WriteLine($"s1 hash code {s1} : {s1.GetHashCode()}");
Console.WriteLine($"s2 hash code {s2} : {s2.GetHashCode()}");

if (s.GetHashCode() == s1.GetHashCode())
{
    Console.WriteLine("s & s1 hash code are equal");
}

Customer c1 = new Customer() { FirstName = "Anil", LastName = "Rathod" };
Customer c2 = new Customer() { FirstName = "Anil", LastName = "Pawar" };
Console.WriteLine($"c1 hash code {c1.GetHashCode()}");
Console.WriteLine($"c2 hash code {c2.GetHashCode()}");


#endregion GetHashCode() method


Console.ReadLine();

namespace VHaaSh
{
    class Student { }
}

class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return FirstName + " " + LastName;
    }

    public override bool Equals(object? obj)
    {
        // to check whether obj is of Type Customer or not
        // bool yes = obj is Customer;

        Customer c = obj as Customer;
        // it wont throw any exeption even if obj is of not Customer type
        // it returns null in this case

        // Customer c = (Customer)obj 
        // it will throw exception if obj is of not Customer type

        return this.FirstName.Equals(c.FirstName)
            && this.LastName.Equals(c.LastName);
    }

    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() ^
            this.LastName.GetHashCode();
    }
}

interface IStudent { }
