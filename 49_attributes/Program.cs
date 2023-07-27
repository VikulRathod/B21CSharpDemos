Calculator c = new Calculator();
c.Add(10, 20);
c.Add(10, 20, 30);
c.Add(10, 10, 10, 10, 10);

Console.ReadLine();

[Obsolete]
class Calculator
{
    [Obsolete("Outdated method. use Add(params int[] numbers)", false)]
    public void Add(int a, int b)
    {
        Console.WriteLine($"Addition : {a + b}");
    }

    [Obsolete]
    public void Add(int a, int b, int c)
    {
        Console.WriteLine($"Addition : {a + b + c}");
    }

    public void Add(params int[] numbers)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine($"Addition : {sum}");
    }
}