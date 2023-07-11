Customer[] customers = new Customer[]
{
    new SilverCustomer(),
    new GoldCustomer(),
    new Enquiry()
};

for (int i = 0; i < customers.Length; i++)
{
    customers[i].Shows();
}

ICustomer[] customers1 = new ICustomer[]
{
new SilverCustomer(), new GoldCustomer()
};

for (int i = 0; i < customers1.Length; i++)
{
    customers1[i].Ticket();
}

Console.ReadLine();

abstract class Customer
{
    public int Amount { get; set; }

    public void Shows()
    {
        Console.WriteLine("*** ALL SHOWS ***");
    }

    //public abstract void Ticket();
}

interface ICustomer
{
    void Ticket();
}

class SilverCustomer : Customer, ICustomer
{
    public void Ticket()
    {
        Console.WriteLine("Silver Ticket is Printed");
    }
}

class GoldCustomer : Customer, ICustomer
{
    public void Ticket()
    {
        Console.WriteLine("Gold Ticket is Printed");
    }
}

class Enquiry : Customer
{

}
