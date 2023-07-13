#region default interface method implementation

//IA a = new A();
//a.Print();


//Console.ReadLine();

//interface IA
//{
//    public void Print()
//    {
//        Console.WriteLine("IA Print()");
//    }
//}

//public class A : IA
//{
//    //public void Print()
//    //{
//    //    Console.WriteLine("A Print()");
//    //}
//}

#endregion default interface method implementation

Student s1 = new Student();
s1.Insert();

Console.ReadLine();

public partial class Customer
{
    partial void Print();

    partial void Print()
    {
        Console.WriteLine("Customer Print()");
    }
}