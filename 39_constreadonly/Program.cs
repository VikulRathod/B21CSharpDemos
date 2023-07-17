Customer c1 = new Customer();
c1.Name = "Test";
// c1.Site = "Flipkart";
c1.Details();

// Customer.Site = "Facebook";

Customer c2 = new Customer();
c2.Name = "Vishal";
// c2.Site = "Flipkart";
c2.Details();

Console.WriteLine(Customer.Site);
// Console.WriteLine(c2.Site);

Console.ReadLine();

class Customer
{
    public string Name;
    // public static string Site;
    // public const string Site = "Flipkart";
    public static readonly string Site = "Flipkart";

    static Customer()
    {
        Site = "Facebook";
    }
    
    public void Details()
    {
        Console.WriteLine($"Name : {Name} Site : {Site}");
    }
}