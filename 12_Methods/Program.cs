using System.Runtime.InteropServices;

Console.WriteLine("Program Starts");
//Add(); // method call
//Add(); // method call

//int r1 = AddA(); // method call
//Console.WriteLine(r1);

//AddB();
//AddB();

//AddC("Vishal"); // Vishal = method argument
//Console.WriteLine("Please enter your name");
//string name = Console.ReadLine();
//AddC(name); // name = method argument

//string r2 = GetFullName("Vishal", "Pawar");
//Console.WriteLine(r2);


//int[] numbers = new int[] { 10, 10, 10, 20 };
//PrintSum(numbers);

//PrintSum(new int[] { 10, 20, 30, 40, 50 });

//int[] numbers1 = null;
//PrintSum(numbers1);

//AddE(10, 20);
//AddE(10);
//AddE();

//AddF(10, 20, 30);
//AddF(10, 20);
//// AddF(100);
//AddF(b:100);

//string name = "Avinash";
//name.ToCharArray();

PrintA(); // call

Console.WriteLine("Program Ends");
Console.ReadLine();


#region Method without return & parameter

void Add()
{
    Console.WriteLine("Please enter first number");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter second number");
    int n2 = int.Parse(Console.ReadLine());

    int addition = n1 + n2;

    Console.WriteLine($"Addition: {n1} + {n2} = {addition}");
}

#endregion Method without return & parameter

#region Method with return & without parameter

int AddA()
{
    Console.WriteLine("Please enter first number");
    int n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter second number");
    int n2 = int.Parse(Console.ReadLine());

    int n = n1 + n2;

    return n;
}

#endregion Method with return & without parameter

#region method with return statement having void return type

void AddB()
{
    Console.WriteLine("Please enter favorite actor");
    string name = Console.ReadLine();

    if (name == "Tushar Kapoor")
    {
        return;
    }

    Console.WriteLine("GOOD CHOICE!!!");
}

#endregion method with return statement having void return type

#region method with parameter

void AddC(string name) // name = method parameter
{
    Console.WriteLine($"Good Morning, {name} !!!");
}

#endregion method with parameter

#region method with return type & parameters

string GetFullName(string firstName, string lastName)
{
    //string fullName = $"{firstName} {lastName}";
    //return fullName;

    return $"{firstName} {lastName}";
}

#endregion method with return type & parameters

#region method to print all numbers in array

void PrintSum(int[] numbers)
{
    if (numbers != null && numbers.Length > 0)
    {
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine($"Total Sum: {sum}");
    }
    else
    {
        Console.WriteLine("EMPTY ARRAY");
    }
}

#endregion method to print all numbers in array

#region default parameter

void AddE(int a = 2, int b = 5)
{
    Console.WriteLine($"Addition: {a} + {b} = {a + b}");
}


#endregion default parameter

#region optional attribute

void AddF([Optional] int a, int b,[Optional] int c)
{
    Console.WriteLine($"Addition: {a} + {b} + {c} = {a + b + c}");
}

#endregion optional attribute

#region method calling

void PrintA() // Calling method
{
    Console.WriteLine("PrintA Called");
    PrintB(); // call
}
void PrintB() // Called method
{
    Console.WriteLine("PrintB Called");
}


#endregion method calling