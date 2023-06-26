class Program
{
    // calling method
    static void Main()
    {
        #region PrintA() method call
        //int a = 10; // local variable
        //Console.WriteLine($"Before Call: {a}");// 10
        //PrintA(a);
        //Console.WriteLine($"After Call: {a}"); // 1000
        #endregion PrintA() method call

        #region PrintB() method call

        //// int a; // value initailization is mandatory in calling method
        //int a = 10;
        //Console.WriteLine($"Before Call a : {a}"); // 10
        //PrintB(ref a);
        //Console.WriteLine($"After Call a : {a}"); // 1000

        #endregion PrintB() method call

        #region PrintC() method call

        //int a = 100, b = 20, sub, mul, div;
        //int r1 = PrintC(a, b, out sub, out mul, out div);
        //Console.WriteLine($"{a} + {b} = {r1}");
        //Console.WriteLine($"{a} - {b} = {sub}");
        //Console.WriteLine($"{a} * {b} = {mul}");
        //Console.WriteLine($"{a} / {b} = {div}");

        #endregion PrintC() method call

        #region PrintD() method call

        int[] numbers1 = new int[] { 10, 10, 10 };
        PrintD(numbers1); // 30

        PrintD(new int[] { 10, 20, 30 }); // 60

        PrintD(10, 10, 10, 10, 10);

        int[] numbers2 = null;
        PrintD(numbers2); // EMPTY ARRAY

        PrintD(null); // EMPTY ARRAY

        PrintE(); // NO ITEMS
        PrintE("A", "N", "I", "L"); // ANIL

        #endregion PrintD() method call

        Console.ReadLine();
    }

    static void PrintD(params int[] numbers)
    {
        if (numbers != null && numbers.Length > 0)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Total Sum: {sum}");
        }
        else
        {
            Console.WriteLine("EMPTY ARRAY");
        }
    }

    static void PrintE(params string[] chars)
    {
        if (chars != null && chars.Length > 0)
        {
            string output = "";
            for (int i = 0; i < chars.Length; i++)
            {
                output += chars[i];
            }
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("NO ITEMS");
        }
    }


    // output parameter
    static int PrintC(int a, int b, out int sub, out int mul, out int div)
    {
        sub = a - b;
        mul = a * b;
        div = a / b;
        return a + b;
    }

    //static bool MyTryParse(string s, out int a)
    //{

    //}

    // ref keyword
    static void PrintB(ref int a)
    {
        // a = 1000; // it is not mandatory to assign value to ref parameter inside called method
        Console.WriteLine($"Inside PrintB() Method a : {a}"); // 1000
    }


    // Pass by value
    // called method
    static void PrintA(int a) // method parameter
    {
        a = 1000; // changed value of parameter
        Console.WriteLine($"Value in PrintA() method : {a}");
    }
}