A a1 = new A();
a1.Print(); // A Print()

A a2 = new B();
a2.Print(); // B Print()

A a3 = new C();
a3.Print(); // C Print()

A a4 = new D();
a4.Print(); // B Print()

Console.ReadLine();

class A
{
    public virtual void Print()
    {
        Console.WriteLine("A Print()");
    }
}

class B : A
{
    public override void Print()
    {
        Console.WriteLine("B Print()");
    }
}

class C : A
{
    public override void Print()
    {
        Console.WriteLine("C Print()");
    }
}

class D : B
{

}