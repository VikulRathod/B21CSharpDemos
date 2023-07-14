#region object var dynamic

//object o = 10;
//Console.WriteLine(o.GetType());
//o = "Vishal";
//Console.WriteLine(o.GetType());
//o = '$';
//Console.WriteLine(o.GetType());
//o = new Customer();
//Console.WriteLine(o.GetType());

//var v = new { Id = 10, Name = "Vishal" };
//Console.WriteLine($"Id : {v.Id} Name : {v.Name}");

//var i = 10; // int
////i = "Vishal"; // error

//// var s; // error

#endregion object var dynamic


#region object var dynamic example

//object o = 10;
//Console.WriteLine(o);
//o = "Vishal";
//Console.WriteLine(o);

//dynamic o1 = 10;
//Console.WriteLine(o1);
//o1 = "Vishal";
//Console.WriteLine(o1);

//var o2 = 10;
//Console.WriteLine(o2);
//// o2 = "Vishal"; // error
//Console.WriteLine(o2);

//var c1 = new Customer();
//c1.Print();
////c1.PrintA(); // error
////c1.PrintB(); // error

//dynamic c2 = new Customer();
//c2.Print();
////c2.PrintA(); // runtime error
////c2.PrintB(); // runtime error


#endregion object var dynamic example

#region dynamic example

dynamic d = new Calculator();
d.Add(10,10);
d.Add('A','B');
d.Add("ABC", "XYZ");


#endregion dynamic example

Console.ReadLine();

class Customer
{
    // var _id; // error
    //void Print(var a) // error
    //{

    //}

    public void Print()
    {
        Console.WriteLine("Print() method called");
    }
}

class Calculator
{
    public void Add<T>(T a, T b)
    {
        // Console.WriteLine(a + b);

        //object o1 = a, o2 = b;
        //Console.WriteLine(o1 + o2);

        //var o1 = a, o2 = b;
        //Console.WriteLine(o1 + o2);

        dynamic o1 = a, o2 = b;
        Console.WriteLine(o1 + o2);
    }
}