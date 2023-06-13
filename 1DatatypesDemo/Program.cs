class Program
{
    static void Main()
    {
        Console.WriteLine("Data Types Demo");

        byte v1 = 10;
        // v1 = 2500;
        Console.WriteLine(v1); // 10
        Console.WriteLine(sizeof(byte));
        Console.WriteLine(byte.MinValue);
        Console.WriteLine(byte.MaxValue);

        short v2 = 10;
        // v2 = 45000;
        Console.WriteLine(v2); // 10
        Console.WriteLine(sizeof(short));
        Console.WriteLine(short.MinValue);
        Console.WriteLine(short.MaxValue);

        int v3 = 10;
        Console.WriteLine(v3); // 10
        Console.WriteLine(sizeof(int));
        Console.WriteLine(int.MinValue);
        Console.WriteLine(int.MaxValue);

        long v4 = 10;
        Console.WriteLine(v4); // 10

        v4 = 20;
        Console.WriteLine(v4); // 20
        Console.WriteLine(sizeof(long));
        Console.WriteLine(long.MinValue);
        Console.WriteLine(long.MaxValue);

        Console.WriteLine("------------------------------------------------------------");

        float f1 = 45.456789f; // float value suffix with f
        Console.WriteLine(f1);
        Console.WriteLine(sizeof(float));
        Console.WriteLine(float.MinValue);
        Console.WriteLine(float.MaxValue);

        double  f2= 45.456789;
        Console.WriteLine(f2);
        Console.WriteLine(sizeof(double));
        Console.WriteLine(double.MinValue);
        Console.WriteLine(double.MaxValue);

        decimal f3 = 45.456789m; // decimal value suffix with m
        Console.WriteLine(f3);
        Console.WriteLine(sizeof(decimal));
        Console.WriteLine(decimal.MinValue);
        Console.WriteLine(decimal.MaxValue);

        Console.WriteLine("------------------------------------------------------------");

        bool b1 = true;
        Console.WriteLine(b1);
        Console.WriteLine(sizeof(bool));

        Console.WriteLine("------------------------------------------------------------");

        char c1 = 'A';
        Console.WriteLine(c1);
        Console.WriteLine(sizeof(char));

        string name = "Vishal";
        Console.WriteLine(name);       

        Console.ReadLine();
    }
}