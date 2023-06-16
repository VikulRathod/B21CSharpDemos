string s = null;
object o = null;
// int? i = null;
bool? b = null;

int? age = null;

// int - non nullable
// int? - nullable

Nullable<int> age1 = null;

string name = "Vishal";
Console.WriteLine($"Name : {name}");
name = null;
Console.WriteLine($"Name : {name}");

int? i = 100;
Console.WriteLine($"i : {i}");
i = null;
Console.WriteLine($"i : {i}");

// int j = (int) i; // int? => int

int j = i ?? 0;
Console.WriteLine($"j : {j}");


name = "Vishal";
Console.WriteLine(name); // Vishal
Console.WriteLine(name.ToUpper()); // VISHAL

name = null;
Console.WriteLine(name); // 
Console.WriteLine(name?.ToUpper());

int x = 10;
string s1 = x.ToString(); // int => string

// "10", "true", "4.45", "456.45f"

Console.ReadLine();