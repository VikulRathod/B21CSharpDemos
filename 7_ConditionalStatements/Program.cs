Console.WriteLine("Welcome, user");

Console.WriteLine("Please enter a number");
int num = int.Parse(Console.ReadLine() ?? "0");

//if(num == 10)
//{
//    Console.WriteLine("TEN");
//}
//else
//{
//    Console.WriteLine("NOT 10");
//}

//if (num == 10)
//{
//    Console.WriteLine("TEN");
//}
//if(num == 20)
//{
//    Console.WriteLine("TWENTY");
//}
//if(num == 30)
//{
//    Console.WriteLine("THIRTY");
//}
////else
////{
////    Console.WriteLine("NOT 10 20 or 30");
////}

//if (num == 10)
//{
//    Console.WriteLine("TEN");
//}
//else if (num == 20)
//{
//    Console.WriteLine("TWENTY");
//}
//else if (num == 30)
//{
//    Console.WriteLine("THIRTY");
//}
//else if (!(num == 40))
//{
//    Console.WriteLine("NOT FOURTY");
//}
//else
//{
//    Console.WriteLine("NOT 10 20 or 30");
//}


//// Ternary operator
//string result =  (num == 10) ? "TEN" : "NOT 10";
//Console.WriteLine(result);

// switch statement
switch (num)
{
    case 10:
        Console.WriteLine("TEN");
        break;
    case 20:
        Console.WriteLine("TWENTY");
        break;
    case 30:
        Console.WriteLine("THIRTY");
        break;
    default:
        Console.WriteLine("NOT 10 20 or 30");
        break;
}

Console.WriteLine("Please enter a grade");
string grade = Console.ReadLine();

switch (grade)
{
    //case "A+":
    //    Console.WriteLine("Distinction");
    //    break;
    case "A+":
    case "A":
        Console.WriteLine("Distinction");
        break;
    case "B":
        Console.WriteLine("First Class");
        break;
    case "C":
        Console.WriteLine("Second Class");
        break;
    case "D":
        Console.WriteLine("Third Class");
        break;
    default:
        Console.WriteLine("INVALID GRADE");
        break;
}

Console.WriteLine("Thank you");

Console.ReadLine();
