// Finding highest number amongst 3 numbers

Console.WriteLine("Please enter first number");
int first = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter second number");
int second = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter third number");
int third = int.Parse(Console.ReadLine());

#region Logic 1

//if (first > second)
//{
//    if (first > third)
//    {
//        Console.WriteLine($"Highest number in {first}, {second}, {third} is {first}.");
//    }
//    else
//    {
//        if (third > second)
//        {
//            Console.WriteLine($"Highest number in {first}, {second}, {third} is {third}.");
//        }
//    }
//}
//else
//{
//    if(second > third)
//    {
//        Console.WriteLine($"Highest number in {first}, {second}, {third} is {second}.");
//    }
//    else
//    {
//        if(third > first)
//        {
//            Console.WriteLine($"Highest number in {first}, {second}, {third} is {third}.");
//        }
//    }
//}

#endregion Logic 1

if (first >= second && first >= third)
{
    Console.WriteLine($"Highest number in {first}, {second}, {third} is {first}.");
}
else if (second >= first && second >= third)
{
    Console.WriteLine($"Highest number in {first}, {second}, {third} is {second}.");
}
else if (third >= first && third >= second)
{
    Console.WriteLine($"Highest number in {first}, {second}, {third} is {third}.");
}


// second example
// if number is divisible by 3 = print THREE
// if number is divisible by 5 = print FIVE
// if number is divisible by 3 as well as 5 = print THREEFIVE

Console.WriteLine("Please enter a number");
int num = int.Parse(Console.ReadLine());

if (num % 3 == 0 && num % 5 == 0)
{
    Console.WriteLine("THREEFIVE");
}
else if (num % 3 == 0)
{
    Console.WriteLine("THREE");
}
else if (num % 5 == 0)
{
    Console.WriteLine("FIVE");
}
else
{
    Console.WriteLine("NOT DIVISBLE BY 3 or 5");
}

int a = 10, b = 5, c = 20;

string result = (a > b) ? ((a > c) ? "FIRST" : ((c > b) ? "THIRD" : "SECOND"))
    : (b > c) ? "SECOND" : (c > a) ? "THIRD" : "FIRST";

string result1 = (a > b) ? ((a > c) ? "FIRST" : "THIRD"):"SECOND";

bool result3 = (a > 0) && (a / b >= 2);
Console.WriteLine(result3);


Console.ReadLine();