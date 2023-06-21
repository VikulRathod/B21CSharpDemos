#region without array

//string name1 = "Ramesh";
//Console.WriteLine(name1);

//string name2 = "Prithvi";
//Console.WriteLine(name2);

//string name3 = "Kunal";
//Console.WriteLine(name3);

#endregion without array

#region array

//// string name = "Ramesh";

//// string[] names = new string[]; // not possible

//string[] names = new string[3];
//names[0] = "Ramesh";
//// names[0] = 10; // array is type safe, same type element it allows
//names[1] = "Pritvi";
//names[2] = "Kunal";
//// names[3] = "Ritesh"; // not possible array size is fixed

//// Console.WriteLine(names[0]); // Ramesh

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

#endregion array

#region array initializer syntax

//// int[] numbers = new int[3];
//int[] numbers = new int[] { 10, 20, 30};

//Console.WriteLine(numbers.Length);

//for (int i = 0;i < numbers.Length;i++)
//{
//    Console.WriteLine(numbers[i]);
//}

#endregion array initializer syntax

#region array example

//for (int i = 1; i <= 5; i++)
//{
//    Console.Write($"{i}\t");
//}

//for (int i = 1; i <= 5; i++)
//{
//	for (int j = 1; j <= 5; j++)
//	{
//        // Console.Write($"{i}i{j}j\t");
//        Console.Write($"*\t");
//    }
//    Console.WriteLine(); // new line
//}

//for (int i = 1; i <= 3; i++)
//{
//    for (int j = 1; j <= 3; j++)
//    {
//        // Console.Write($"{i}i{j}j\t");

//        //if (i == j || (i == 3 && j <= 1) || (i <= 1 && j == 3))
//        //{
//        //    Console.Write($"*\t");
//        //}
//        //else
//        //{
//        //    Console.Write($" \t");
//        //}

//        if (i == j || (i == 3 && j <= 1) || (i <= 1 && j == 3))
//        {
//            Console.Write($"\t");
//        }
//        else
//        {
//            Console.Write($"*\t");
//        }
//    }
//    Console.WriteLine(); // new line
//}


//for (int i = 1; i <= 5; i++)
//{
//	for (int j = 1; j <= i; j++)
//	{
//		Console.Write($"{j}\t");
//		// Console.Write($"*\t");
//	}
//	Console.WriteLine();
//}

//for (int i = 5; i >= 1; i--)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write($"{j}\t");
//        // Console.Write($"*\t");
//    }
//    Console.WriteLine();
//}

#endregion array example

Console.ReadLine();