class Program
{
    // calling method
    static void Main()
    {
        int a = 10; // local variable
        Console.WriteLine($"Before Call: {a}");
        PrintA(ref a);
        Console.WriteLine($"After Call: {a}");

        Console.ReadLine();
    }

    // called method
    static void PrintA(ref int a) // method parameter
    {
        a = 1000; // changed value of parameter
        Console.WriteLine($"Value in PrintA() method : {a}");
    }
}