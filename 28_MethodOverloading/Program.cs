
//Sample s = new Sample();
//s.Print();
//s.Print(10);
//s.Print("ABC");
////Print(10, 10);

//Sample s1 = new Sample();
//s1.Print();
//// s1.Print(10); // void / string

Sample s3 = new Sample();
s3.Print(10); // short but calling int only
s3.Print(20); // int
short a = 10;
s3.Print(a); // short definition

B b = new B();
b.Print(); // form A class 


Console.ReadLine();

class Sample
{
    public void Print()
    {
        Console.WriteLine("Print()");
    }

    public void Print(int n)
    {
        Console.WriteLine("Print(int n)");
    }

    public void Print(short n)
    {
        Console.WriteLine("Print(short n)");
    }

    public void Print(out int n)
    {
        n = 10;
        Console.WriteLine("Print(out int n)");
    }

    //public string Print(int n)
    //{
    //    return "Print(int n)";
    //}

    public void Print(string s)
    {
        Console.WriteLine("Print(string s)");
    }

    public void Print(int n, string s)
    {
        Console.WriteLine("Print(int n, string s)");
    }

    public void Print(string s, int n)
    {
        Console.WriteLine("Print(string s, int n)");
    }

    public void Print(int[] n) { }

    public void Print(params string[] n) { }
}


// method overloading using multiple classes
class A
{
    public void Print()
    {
        Console.WriteLine("A Print()");
    }
}
class B : A
{
    public void Print(int a)
    {
        Console.WriteLine("A Print()");
    }
}