#region collection traditional way - array

//int[] numbers = new int[2];
//numbers[0] = 1;
//numbers[1] = 2;
//// numbers[2] = 3; // runtime error = IndexOutOfRangeException

#endregion collection traditional way - array

#region Collection class = Arraylist

using System.Collections;

ArrayList numbers = new ArrayList();
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
Console.WriteLine("*** Original Items In ArrayList ***");

Sample.Print(numbers);

numbers.Add(40);
Console.WriteLine("*** After Add(40) ***");
Sample.Print(numbers);

ICollection temp = new ArrayList() { 50, 60 };
numbers.AddRange(temp);
Console.WriteLine("*** After AddRange(temp); ***");
Sample.Print(numbers);

numbers.Insert(0, 5);
Console.WriteLine("*** After Insert(0, 5) ***");
Sample.Print(numbers);

ICollection temp1 = new ArrayList() { 15, 16, 17 };
numbers.InsertRange(2, temp1);
Console.WriteLine("*** After InsertRange(2, temp1); ***");
Sample.Print(numbers);

bool b1 = numbers.Contains(10);
Console.WriteLine($"10 : Exists : {b1}");
b1 = numbers.Contains(11);
Console.WriteLine($"11 : Exists : {b1}");

numbers.RemoveAt(0);
Console.WriteLine("*** After RemoveAt(0) ***");
Sample.Print(numbers);

numbers.RemoveRange(0, 2);
Console.WriteLine("*** After RemoveRange(0, 2) ***");
Sample.Print(numbers);

numbers.Remove(60);
Console.WriteLine("*** After Remove(60) ***");
Sample.Print(numbers);

int i1 = numbers.IndexOf(40);
Console.WriteLine($"Index of 40 element : {i1}");

//numbers.Clear();
//Sample.Print(numbers);

#endregion Collection class = Arraylist



Console.ReadLine();

class Sample
{
    public static void Print(ArrayList numbers)
    {
        Console.WriteLine($"Number of Items : {numbers.Count}");
        //for (int i = 0; i < numbers.Count; i++)
        //{
        //    Console.Write($"{numbers[i]} "); // 10 20 30
        //}
        foreach (int num in numbers)
        {
            Console.Write($"{numbers.IndexOf(num)}. {num}, ");
        }
        Console.WriteLine(); // new line
    }
}