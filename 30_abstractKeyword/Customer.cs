public abstract class Customer
{
    private string _siteName;
    public int TicketAmount { get; set; }

    static Customer()
    {
        Console.WriteLine("static Customer() constructor called");
    }

    public Customer()
    {
        _siteName = "Flipkart";
    }

    public virtual void Shows()
    {
        Console.WriteLine("*** ALL TODAYS SHOWS ***");
    }

    public abstract void Ticket();
}

//public abstract class Customer1
//{
//    public abstract void Ticket();
//}

public class SilverCustomer : Customer
{
    public override void Ticket()
    {
        Console.WriteLine("Silver Ticket Printed");
    }
}

public class GoldCustomer : Customer
{
    public override void Ticket()
    {
        Console.WriteLine("Gold Ticket Printed");
    }
}

//public class Enquiry : Customer
//{
//    //public override void Ticket()
//    //{
//    //    throw new NotImplementedException();
//    //}
//}