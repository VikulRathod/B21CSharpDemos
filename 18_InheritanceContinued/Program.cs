using _18_InheritanceContinued;

class Progam
{
    static void Main()
    {
        //Customer c1 = new Customer();
        //c1.AllShows();
        //Console.WriteLine("Please provide your seat choice");
        //string type = Console.ReadLine();

        //int amount = c1.GetTicketAmount(type);
        //Console.WriteLine($"Ticket Amount is {amount}");
        //c1.PrintTicket();

        Customer sc = new SilverCustomer();
        // sc is a reference variable of type SilverCustomer class 
        // pointing to SilverCustoer type object
        sc.AllShows();
        int amt = sc.GetTicketAmount();
        Console.WriteLine(amt);
        // sc.PrintTicket();
        ((SilverCustomer)sc).PrintTicket();

        Console.WriteLine("********************************************");

        GoldCustomer gc = new GoldCustomer();
        gc.AllShows();
        amt = gc.GetTicketAmount();
        Console.WriteLine(amt);
        gc.PrintTicket();

        Console.WriteLine("********************************************");

        PlatinumCustomer pc = new PlatinumCustomer();
        pc.AllShows();
        amt = pc.GetTicketAmount();
        Console.WriteLine(amt);
        pc.PrintTicket();

        Console.WriteLine("********************************************");

        //Customer c1 = new Customer(); // bc => bc
        //c1.AllShows();

        //Customer c2 = new SilverCustomer(); // bc => dc
        //Customer c3 = new GoldCustomer();
        //Customer c4 = new PlatinumCustomer();

        //SilverCustomer sc1 = new SilverCustomer(); // dc => dc
        //SilverCustomer sc2 = (SilverCustomer) new Customer(); // not possible

        //         int[] numbers = new int[3];
        Customer[] customers = new Customer[3];
        customers[0] = new SilverCustomer();
        customers[1] = new GoldCustomer();
        customers[2] = new PlatinumCustomer();

        for (int i = 0; i < customers.Length; i++)
        {
            int amount = customers[i].GetTicketAmount();
            Console.WriteLine(amount);
            customers[i].PrintTicket();
        }


        Console.ReadLine();
    }
}