#region == with int operands
//int a = 10;
//// int b = a;
//int b = 10;
//if(a == b) // operator ==, operands a, b
//{
//    Console.WriteLine("a & b are EQUAL");
//}
//else
//{
//    Console.WriteLine("a & b are NOT EQUAL");
//}
#endregion == with int operands

#region == with string operands

//string s1 = "A";
//// string s2 = s1;
//string s2 = "A";
//if(s1 == s2) // operator ==, operands s1, s2
//{
//    Console.WriteLine("s1 & s2 are EQUAL");
//}
//else
//{
//    Console.WriteLine("s1 & s2 are NOT EQUAL");
//}

#endregion == with string operands

#region == with Customer operands
Customer c1 = new Customer() { FirstName = "Anil", LastName = "Rathod"};
// Customer c2 = c1; 
Customer c2 = new Customer() { FirstName = "Anil", LastName = "Rathod"};
if(c1 == c2) // operator ==, operands c1, c2
{
    Console.WriteLine("c1 & c2 are EQUAL");
}
else
{
    Console.WriteLine("c1 & c2 are NOT EQUAL");
}

#endregion == with Customer operands

Console.ReadLine();

class Customer
{
    public int CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // many more 

    public static bool operator ==(Customer a, Customer b)
    {
        return a.FirstName == b.FirstName &&
            a.LastName == b.LastName;
    }

    public static bool operator !=(Customer a, Customer b)
    {
        return a.FirstName != b.FirstName &&
            a.LastName != b.LastName;
    }
}