#region generic method

//Calculator c1 = new Calculator();
//bool b1 = c1.AreEqual(10, 10);
//Console.WriteLine($"AreEqual(10, 10) : {b1}");

//b1 = c1.AreEqual("Vishal", "Vishal");
//Console.WriteLine($"AreEqual(\"Vishal\", \"Vishal\") : {b1}");

//b1 = c1.AreEqual(10.5f, 21.5f);
//Console.WriteLine($"AreEqual(10.5f, 21.5f) : {b1}");

//b1 = c1.AreEqual<char>('$', '$');
//Console.WriteLine($"AreEqual<char>('$', '$') : {b1}");

// b1 = c1.AreEqual(10, "Vishal");

#endregion generic method

using System.Security.Cryptography;

Calculator<int> c1 = new Calculator<int>();
bool b1 = c1.AreEqual(10, 10);

Calculator<string> c2 = new Calculator<string>();
c2.AreEqual("A", "B");


Console.ReadLine();

//class Calculator
//{
//public bool AreEqual(int a, int b)
//{
//    return a == b;
//}

//public bool AreEqual(string a, string b)
//{
//    return a == b;
//}

//public bool AreEqual(float a, float b)
//{
//    return a == b;
//}

//    public bool AreEqual<T>(T a, T b)
//    {
//        return a.Equals(b); // same working like == operator
//    }
//}

//class Calculator<T, T1, T2>
class Calculator<T>
{
    //public T1 Property1 { get; set; }
    //public T2 Property2 { get; set; }

    public bool AreEqual(T a, T b)
    {
        return a.Equals(b);
    }
}

// Calculator<string, string, float> c1 =
// new Calculator<string, string, float>();