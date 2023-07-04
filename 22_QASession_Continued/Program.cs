#region ternary operator

// int i = 10;

#region if else with block

//if (i == 10)
//{
//    Console.WriteLine("TEN");
//}
//else
//{
//    Console.WriteLine("NOT TEN");
//}

#endregion if else with block

#region if else without block

//// it is not mandatory to write curly braces for single line
//// use block/ curly braces when we want to write multi line code
//if (i == 10)
//    Console.WriteLine("TEN");
//else
//    Console.WriteLine("NOT TEN");

#endregion if else without block

#region ternary operator

//// (i == 10) ? Console.WriteLine("TEN") : Console.WriteLine("NOT TEN");

//string result = (i == 10) ? "TEN" : "NOT TEN";
//Console.WriteLine(result);

//bool b1 = (i == 10) ? true : false;

#endregion ternary operator

#endregion ternary operator

#region Parse() TryParse() methods

//string input = "ABC";
//// int i = input; // string  => int

////int i1 = int.Parse(input);
////Console.WriteLine(i1);

//int i1;
//bool status = int.TryParse(input, out i1);
//Console.WriteLine($"Coversion Status : {status} Converted Value : {i1}");

#endregion Parse() TryParse() methods

#region bubble sort

int[] numbers = new int[] { 2, 45, 14, 23, 3 }; // 5 / 0 - 4

Console.WriteLine("Before Sort");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}

Console.WriteLine("\nAfter Sort");

for (int i = 0; i < numbers.Length; i++)
{
    // for (int j = (i + 1);i < numbers.Length - 1 && j < numbers.Length; j++)
    for (int j = i; j < numbers.Length; j++)
    {
        //if (numbers[i] == numbers[j])
        //{
        //    continue;
        //}
        // descending order
        //else if (numbers[i] < numbers[j])
        //{
        //    int temp = numbers[j];
        //    numbers[j] = numbers[i];
        //    numbers[i] = temp;
        //}
        // ascending order //  2, 45, 14, 23, 3
        // 2,14, 45, 23, 3 // 2,14, 23, 45, 3 // 2,14, 23, 3, 45
        if (numbers[i] > numbers[j])
        {
            int temp = numbers[j];
            numbers[j] = numbers[i];
            numbers[i] = temp;
        }
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}

#endregion bubble sort

Console.ReadLine();

namespace Name1
{
    public class A
    {

    }
}

namespace Name2
{
    using Name1;
    public class B : A
    {

    }
}