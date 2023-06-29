class Program
{
    static void Main()
    {
        SilverCustomer sc = new SilverCustomer();
        sc.GetShows();

        GoldCustomer gc = new GoldCustomer();
        gc.GetShows();

        PlatinumCustomer pc = new PlatinumCustomer();
        pc.GetShows();

        Console.ReadLine();
    }
}