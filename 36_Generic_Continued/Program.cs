Customer<int, short, string> c = new Customer<int, short, string>();
string result = c.Print(10, 20);
Console.WriteLine(result);

Customer<string, string, string> c1 = new Customer<string, string, string>();
result = c1.Print("Vishal", "Pawar");
Console.WriteLine(result);

Console.ReadLine();


class Customer<T1, T2, TOut>
{
    public TOut Print(T1 a, T2 b)
    {
        dynamic n1 = a;
        dynamic n2 = b;
        dynamic result = string.Format($"{a} {b}");

        return result;
    }
}