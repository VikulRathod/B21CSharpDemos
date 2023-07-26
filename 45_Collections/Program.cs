#region collection traditional way - array

//int[] numbers = new int[2];
//numbers[0] = 1;
//numbers[1] = 2;
//// numbers[2] = 3; // runtime error = IndexOutOfRangeException

#endregion collection traditional way - array

#region Collection class = Arraylist

//using System.Collections;

//ArrayList numbers = new ArrayList();
//numbers.Add(10);
//numbers.Add(20);
//numbers.Add(30);
//Console.WriteLine("*** Original Items In ArrayList ***");

//Sample.Print(numbers);

//numbers.Add(40);
//Console.WriteLine("*** After Add(40) ***");
//Sample.Print(numbers);

//ICollection temp = new ArrayList() { 50, 60 };
//numbers.AddRange(temp);
//Console.WriteLine("*** After AddRange(temp); ***");
//Sample.Print(numbers);

//numbers.Insert(0, 5);
//Console.WriteLine("*** After Insert(0, 5) ***");
//Sample.Print(numbers);

//ICollection temp1 = new ArrayList() { 15, 16, 17 };
//numbers.InsertRange(2, temp1);
//Console.WriteLine("*** After InsertRange(2, temp1); ***");
//Sample.Print(numbers);

//bool b1 = numbers.Contains(10);
//Console.WriteLine($"10 : Exists : {b1}");
//b1 = numbers.Contains(11);
//Console.WriteLine($"11 : Exists : {b1}");

//numbers.RemoveAt(0);
//Console.WriteLine("*** After RemoveAt(0) ***");
//Sample.Print(numbers);

//numbers.RemoveRange(0, 2);
//Console.WriteLine("*** After RemoveRange(0, 2) ***");
//Sample.Print(numbers);

//numbers.Remove(60);
//Console.WriteLine("*** After Remove(60) ***");
//Sample.Print(numbers);

//int i1 = numbers.IndexOf(40);
//Console.WriteLine($"Index of 40 element : {i1}");

////numbers.Clear();
////Sample.Print(numbers);

#endregion Collection class = Arraylist

#region Collection class = Hashtable

//using System.Collections;

//Hashtable students = new Hashtable();
//students.Add("Pramod", new Sample());
//students.Add(1, "Ramesh");
//students.Add(2, "Kunal");
//students.Add(3, "Snehal");

//Console.WriteLine("*** Original Collection Elements ***");
//Console.WriteLine($"Number of Elements : {students.Count}");
//foreach (DictionaryEntry item in students)
//{
//    Console.WriteLine($"{item.Key} : {item.Value}");
//}

////foreach (object item in students.Keys)
////{
////    Console.WriteLine(item);
////}

//students.Add(4, "Shital");
//Console.WriteLine("*** After Add(4, \"Shital\") ***");
//Console.WriteLine($"Number of Elements : {students.Count}");
//foreach (DictionaryEntry item in students)
//{
//    Console.WriteLine($"{item.Key} : {item.Value}");
//}

//if (!students.ContainsKey(4))
//{
//    students.Add(4, "Ritesh");
//    Console.WriteLine("*** After Add(4, \"Ritesh\") ***");
//    Console.WriteLine($"Number of Elements : {students.Count}");
//    foreach (DictionaryEntry item in students)
//    {
//        Console.WriteLine($"{item.Key} : {item.Value}");
//    }
//}
//else
//{
//    Console.WriteLine("Element with Key 4 is already exists.");
//}

//// value by its key
//string name = students[2].ToString();
//Console.WriteLine($"Element with Key 2 is {name}");


//Console.ReadLine();

#endregion Collection class = Hashtable

#region Collection class = Stack

//using System.Collections;

//Stack lift = new Stack();
//lift.Push("Ramesh");
//lift.Push("Umesh");
//lift.Push("Pandurang");

//Console.WriteLine($"Number of People : {lift.Count}"); // 3

//string p = lift.Pop().ToString();
//// string p = lift.Peek().ToString();
//Console.WriteLine($"Pop() : {p}"); // Pandurang

//Console.WriteLine($"Number of People : {lift.Count}"); // 2

////p = lift.Pop().ToString();
////Console.WriteLine($"Pop() : {p}"); // Umesh

////Console.WriteLine($"Number of People : {lift.Count}"); // 1

//lift.Push("Akash");
//Console.WriteLine($"Number of People : {lift.Count}"); // 3
//p = lift.Pop().ToString(); 
//Console.WriteLine($"Pop() : {p}"); // Akash
//Console.WriteLine($"Number of People : {lift.Count}"); // 2


#endregion Collection class = Stack

#region Collection class = Queue

//using System.Collections;

//Queue atm = new Queue();
//atm.Enqueue("Vishal");
//atm.Enqueue("Akash");
//atm.Enqueue("Snehal");

//Console.WriteLine($"Number of peple : {atm.Count}"); // 3

//// string p = atm.Dequeue().ToString();
//string p = atm.Peek().ToString();
//Console.WriteLine($"Dequeue() : {p}"); // Vishal

//Console.WriteLine($"Number of peple : {atm.Count}"); // 2


#endregion Collection class = Queue


using System.Collections;

ArrayList a = new ArrayList();

ICollection<int> defaultList = new List<int>() { 43, 53, 63 };

List<int> l = new List<int>();
l.Add(10);
l.AddRange(defaultList);


HashSet<int> h = new HashSet<int>();

Customer customers = new Customer();
foreach (var item in customers)
{

}


Console.ReadLine();

class Sample
{
    //public static void Print(ArrayList numbers)
    //{
    //    Console.WriteLine($"Number of Items : {numbers.Count}");
    //    //for (int i = 0; i < numbers.Count; i++)
    //    //{
    //    //    Console.Write($"{numbers[i]} "); // 10 20 30
    //    //}
    //    foreach (int num in numbers)
    //    {
    //        Console.Write($"{numbers.IndexOf(num)}. {num}, ");
    //    }
    //    Console.WriteLine(); // new line
    //}
}

class Customer : IEnumerable
{
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}