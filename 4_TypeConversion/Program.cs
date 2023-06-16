byte b1 = 255;
int i1 = b1; // byte => int
Console.WriteLine(i1); // 255

// short s = i1; // int => short
// Cannot implicitly convert type 'int' to 'short'. An explicit conversion exists (are you missing a cast?)	4_TypeConversion C:\Users\user\source\repos\B21CSharpDemos\4_TypeConversion\Program.cs	5	N/A

short s = (short)i1;
Console.WriteLine(s);

float f = i1; // int => float
Console.WriteLine(f);

f = 25.50f;
int i2 = (int)f; // float => int
Console.WriteLine(i2);

string s1 = "1";
string s2 = "1";

int n1 = int.Parse(s1);
int n2 = int.Parse(s2);

Console.WriteLine(s1 + s2); // 11
Console.WriteLine(n1 + n2); // 2

s1 = "1OO";
// int n3 = int.Parse(s1); // throws runtime error
int n3;
// int.TryParse(s1, out n3); // in case of conversion error => handles runtime error and returns default value

bool b2 = int.TryParse(s1, out n3);
Console.WriteLine($"{b2} : {n3}"); // False, 0

s1 = "1000";
b2 = int.TryParse(s1, out n3);
Console.WriteLine($"{b2} : {n3}"); // True, 1000

string s3 = "true";
// bool b3 = bool.Parse(s3);
bool b3 = Convert.ToBoolean(s3);
Console.WriteLine($"{s3} : {b3}");

s3 = "456.124";
// double d = double.Parse(s3);
double d = Convert.ToDouble(s3);
Console.WriteLine($"{s3} : {d}");

//    Convert.ToInt16() = short
//    Convert.ToInt32() = int
//    Convert.ToInt64() = long
//    Convert.ToSingle() = float

string s4 = null;
//int j1 = int.Parse(s4);
//Console.WriteLine(j1);
int j2 = Convert.ToInt32(s4);
Console.WriteLine(j2);

// diff : Parse() & Convert class method
// Parse() method throws error when input string is null
// Convert class method handles error and returns default value when input string is null

Console.ReadLine();