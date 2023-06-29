public class Customer
{
    public void GetShows()
    {
        Console.WriteLine("** ALL TODAYS SHOWS **");
    }
}

public class SilverCustomer : Customer
{
    public int GetTicketAmount()
    {
        return 150;
    }

    public void PrintTicket()
    {
        Console.WriteLine("** SILVER TICKET **");
    }
}

public class GoldCustomer : Customer
{
    public int GetTicketAmount()
    {
        return 250;
    }

    public void PrintTicket()
    {
        Console.WriteLine("** GOLD TICKET **");
    }
}

public class PlatinumCustomer : Customer
{
    public int GetTicketAmount()
    {
        return 500;
    }

    public void PrintTicket()
    {
        Console.WriteLine("** PLATINUM TICKET **");
    }
}