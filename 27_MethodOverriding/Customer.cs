public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public virtual void Print()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName}");
    }

    public virtual void PrintA()
    {
        Console.WriteLine("Customer PrintA() Called");
    }
}

public class SilverCustomer : Customer
{
    #region method hiding
    //new public void Print()
    //{
    //    Console.WriteLine($"Full Name : {FirstName} {LastName} : SILVER");
    //}
    #endregion method hiding

    #region method overriding
    public override void Print()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName} : SILVER");
    }
    #endregion method overriding

    public override void PrintA()
    {
        Console.WriteLine("Customer PrintA() Called");
    }
}

public class GoldCustomer : Customer
{
    #region method hiding
    //new public void Print()
    //{
    //    Console.WriteLine($"Full Name : {FirstName} {LastName} : GOLD");
    //}
    #endregion method hiding

    #region method overriding
    public override void Print()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName} : GOLD");
    }
    #endregion method overriding
}

public class AdvancedSilverCustomer : SilverCustomer
{
    public override void Print()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName} : ADVANCED SILVER");
    }
}