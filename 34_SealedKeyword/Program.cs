

Console.ReadLine();

// sealed class A
class A
{
    public virtual void Print()
    {
        Console.WriteLine("A Print()");
    }
}

class B : A
{
    public sealed override void Print()
    {
        Console.WriteLine("B Print()");
    }
}

class C : B
{
    //public override void Print()
    //{
    //    Console.WriteLine("C Print()");
    //}
}

//static class X { }
//class Y : X { } // cannot inherit static class