Student s1 = new Student() { RollNumber = 1, Name = "Kunal", City = "Pune" };
s1.Print();

#region direct copy
//// 1 way to copy object
//Student s2 = s1;
//// s2.Print();

//// problem
//// City is different for s2 object
//s2.City = "Mumbai";

//s2.Print();

//s1.Print(); // we are not expecting City as Mumbai for s1, City should be same Pune

#endregion direct copy

#region using parameterized constructor

//Student s2 = new Student(s1.RollNumber, s1.Name, s1.City);
//s2.Print();

#endregion using parameterized constructor

#region 3 using copy constructor

Student s2 = new Student(s1);
s2.City = "Mumbai";
s2.Print();

//Student s2 = new Student();
//s2.RollNumber = s1.RollNumber;
//s2.Name = s1.Name;
//s2.City = s1.City();
//s2.Print();

#endregion 3 using copy constructor

NumberSeries ns = new NumberSeries();
Console.WriteLine("Please enter target number to print fibanacii series");
int input = int.Parse(Console.ReadLine());
ns.PrintFibonacciSeries(input);


Console.WriteLine();
B b = new B();

Console.ReadLine();



public class Student
{
    public int RollNumber;
    public string Name;
    public string City;
    // many more

    public Student() { }

    public Student(int rn, string name, string city)
    {
        RollNumber = rn; Name = name; City = city;
    }

    public Student(Student s)
    {
        RollNumber = s.RollNumber; Name = s.Name; City = s.City;
    }

    public void Print()
    {
        Console.WriteLine($"Details: RollNumber : {RollNumber} Name : {Name} City : {City}");
    }

    // return null value based on condition/ logic
    public string GetValue(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return null;
        }
        else
        {
            return $"Hello, {name}";
        }
    }
}

public class NumberSeries
{
    public void PrintFibonacciSeries(int lenght)
    {
        int n1 = 1;
        int n2 = 1;

        Console.Write($"{n1} {n2} ");
        int n3 = 0;
        for (int i = 1; (n1 + n2) < lenght; i++)
        {
            n3 = n1 + n2;
            Console.Write($"{n3} ");
            n1 = n2;
            n2 = n3;
        }
    }
}


class A
{
    public string Name = "A";
    public A(string msg)
    {
        Console.WriteLine($"A(string msg) : {msg}");
    }
}
class B : A
{
    public string Name = "B";
    public B() : base("Hello")
    {
        Console.WriteLine("B()");
        Console.WriteLine(Name); // B
        Console.WriteLine(base.Name); // A
    }
}