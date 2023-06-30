class Program
{
    static void Main()
    {
        //A a1 = new A();
        //a1.Print(); // A

        //B b1 = new B();
        //b1.Print(); // B

        //A a2 = new B();
        //a2.Print(); // A

        //A a1 = new A();
        //// A a2 = new B();
        //B b1 = new B();

        A a1 = new A("XYZ");
        B b1 = new B("XYZ");

        Console.ReadLine();
    }
}

class A
{
    public string Name = "V#";

    //public A()
    //{
    //    Console.WriteLine("A()");
    //}

    //public void Print()
    //{
    //    Console.WriteLine("A");
    //}

    public A(string s)
    {
        Console.WriteLine("A(string s)");
        Console.WriteLine(Name);
    }
}

class B : A
{
    public string Name = "V# TECH";

    //public B()
    //{
    //    Console.WriteLine("B()");
    //}

    public B(string s) : base(s)
    {
        Console.WriteLine("B(string s)");
        Console.WriteLine(Name);
        Console.WriteLine(base.Name); // it will access base class Name value
    }

    // method hiding
    //new public void Print()
    //{
    //    Console.WriteLine("B");
    //}
}