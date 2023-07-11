ICustomer c = new Customer();
c.Print();

AB ab = new AB();
ab.PrintA();
ab.PrintB();
// ab.Print();
((IA)ab).Print(); // IA Print()
((IB)ab).Print(); // IB Print()

IA ia = new AB();
ia.PrintA();
ia.Print();

IB ib = new AB();
ib.PrintB();
ib.Print();

Console.ReadLine();


interface ICustomer
{
    //int Id; // no fields

    //// no constructor
    //public ICustomer() 
    //{

    //}

    public int Id { get; set; }

    public void Print();

    public void PrintA()
    {
        Console.WriteLine("ICustomer PrintA()");
    }
}

class Customer : ICustomer
{
    public void Print()
    {
        Console.WriteLine("Customer Print()");
    }

    private int _id;
    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }

}

interface IA
{
    void PrintA();
    void Print();
}
interface IB
{
    void PrintB();
    void Print();
}

class AB : IA, IB
{
    void IA.Print()
    {
        Console.WriteLine("IA Print()");
    }

    void IB.Print()
    {
        Console.WriteLine("IB Print()");
    }

    public void PrintA()
    {
        Console.WriteLine("PrintA()");
    }

    public void PrintB()
    {
        Console.WriteLine("PrintB()");
    }
}