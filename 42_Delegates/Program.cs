#region singlecast delegate

//Customer c = new Customer();
//// c.Print();

////PrintDel pd = new PrintDel(c.Print); // 2nd create instance
////// pd(); // 3rd calling / invoking delegating
////pd.Invoke();

//// PrintDel pd = c.Print;
//// pd();

//PrintDel pd = c.PrintB;
//c.PrintA(pd);

//PrintDel1 pd1 = c.PrintC;
//pd1("Vishal");

//Console.ReadLine();

//delegate void PrintDel(); // 1st delegate declaration
//delegate void PrintDel1(string msg);

//class Customer
//{
//    public void Print()
//    {
//        Console.WriteLine("Print() Method Called");
//    }

//    public void PrintA(PrintDel a)
//    {
//        a(); // calling delegate
//        Console.WriteLine("PrintA() method called");
//    }

//    public void PrintB()
//    {
//        Console.WriteLine("PrintB() method called");
//    }

//    public void PrintC(string msg)
//    {
//        Console.WriteLine($"Hello, {msg}");
//    }
//}

#endregion singlecast delegate

#region multicast delegate

//Customer c = new Customer();
//PrintDel pd1 = c.PrintA;
//PrintDel pd2 = c.PrintB;
//PrintDel pd3 = c.PrintC;
//PrintDel pd = pd3 + pd1 + pd2 - pd3;
//pd();

//PrintDel pd = c.PrintA;
//pd += c.PrintB;
//pd += c.PrintC;
//pd -= c.PrintB;
//pd();

Student s = new Student();
PrintDelegate pd = s.PrintA;
pd += s.PrintB;
pd += s.PrintC;
//string result = pd();
//Console.WriteLine(result);
Delegate[] pds = pd.GetInvocationList();
for (int i = 0; i < pds.Length; i++)
{
    try
    {
        string result = pds[i].DynamicInvoke().ToString();
        Console.WriteLine(result);
    }
    catch
    {
        Console.WriteLine("Error found in one method");
    }
}


Console.ReadLine();

delegate void PrintDel();

class Customer
{
    public void PrintA()
    {
        Console.WriteLine("A");
    }
    public void PrintB()
    {
        Console.WriteLine("B");
    }
    public void PrintC()
    {
        Console.WriteLine("C");
    }
}

delegate string PrintDelegate();

class Student
{
    public string PrintA()
    {
        return "A";
    }
    public string PrintB()
    {
        throw new Exception("Exception in PrintB method");
        // return "B";
    }
    public string PrintC()
    {
        return "C";
    }
}

#endregion multicast delegate