
int a = 10, b = 10;
int c = a + b; // operator +, operands a, b
Console.WriteLine($"{a} + {b} = {c}");

string s1 = "Vishal", s2 = "Pawar";
string s3 = s1 + s2; // operator +, operands s1, s2
Console.WriteLine($"{s1} + {s2} = {s3}");

Calculator c1 = new Calculator() { Number = 100 };
Calculator c2 = new Calculator() { Number = 20 };
Calculator c3 = c1 + c2; // // operator +, operands c1, c2
// Calculator c3 = new Calculator() { Number = c1.Number + c2.Number};
Console.WriteLine($"{c1.Number} + {c2.Number} = {c3.Number}" +
    $"\n {c1.Number1} + {c2.Number1} = {c3.Number1}");

Console.ReadLine();

public class Calculator
{
    public int Number { get; set; }
    public int Number1 { get; set; }

    public static Calculator operator +(Calculator c1, Calculator c2)
    {
        Calculator c = new Calculator()
        {
            Number = c1.Number + c2.Number,
            Number1 = c1.Number1 + c2.Number1
        };

        return c;
    }
}

