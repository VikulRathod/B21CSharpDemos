public abstract class Customer
{
    private string _siteName;
    public int TicketAmount { get; set; }

    public Customer()
    {
        _siteName = "Flipkart";
    }

    public void Shows()
    {
        Console.WriteLine("*** ALL TODAYS SHOWS ***");
    }

    public abstract void Ticket();
}

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