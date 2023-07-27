Calculator c = new Calculator();
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
foreach (int num in c.GetEven(numbers))
{
    Console.Write($"{num} ");
}

Console.ReadLine();

class Calculator
{
    public IEnumerable<int> GetEven(List<int> numbers)
    {
        // List<int> result = new List<int>();

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                //if(num % 3 == 0)
                //{
                //    continue;
                //}

                // result.Add(num);
                yield return num;
            }
        }

        // return result;
    }
}