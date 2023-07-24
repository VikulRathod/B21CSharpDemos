#region Predicate<T> Delegate

//// public delegate bool Predicate<in T>(T obj);
//Predicate<int> d1 = Sample.PrintA;
//Console.WriteLine(d1(10)); // True
//Console.WriteLine(d1(11)); // False

//Predicate<string> d2 = delegate (string s) {
//    return s.Length > 5;
//};

//Console.WriteLine(d2("Anil")); // False
//Console.WriteLine(d2("Vishal")); // True

//Predicate<int> d3 = i => i % 5 == 0;
//Console.WriteLine(d3(9)); // False
//Console.WriteLine(d3(50)); // True

#endregion Predicate<T> Delegate

#region Action<T> Delegate

//// public delegate void Action<in T>(T obj);
//Action<string> ad1 = s => Console.WriteLine(s.ToUpper());

//ad1("Vishal"); // VISHAL
//ad1("Anil"); // ANIL

//// public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
//Action<string, string> ad2 = (s1, s2 ) => 
//Console.WriteLine($"Full Name : {s1} {s2}");
//ad2("Anil", "Rathod"); // Full Name : Anil Rathod

//// public delegate void Action();
//Action ad3 = () => Console.WriteLine("HELLO");
//ad3();

#endregion Action<T> Delegate

#region Func<T> Delegate

// public delegate TResult Func<out TResult>();
using System.Reflection.Metadata.Ecma335;

Func<string> fd1 = () => "GOOD MORNING!!!";
Console.WriteLine(fd1());

// Func<string> fd11 = delegate { return "Hello, Welcome";  };

// public delegate TResult Func<in T, out TResult>(T arg);
Func<string, int> fd2 = s => s.Length;
Console.WriteLine(fd2("Anil")); // 4
Console.WriteLine(fd2("OM")); // 2

#endregion Func<T> Delegate

Console.ReadLine();

class Sample
{
    public static bool PrintA(int i)
    {
        return i % 2 == 0;
    }

}