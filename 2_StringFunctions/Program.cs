// top level statements

//Console.WriteLine("Hello");
//Console.ReadLine();

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Hello");
//        Console.ReadLine();
//    }
//}

// string is important type in any language

string name = "Vishal";
Console.WriteLine(name); // Vishal

string n1 = name.ToUpper();
Console.WriteLine(n1); // VISHAL

n1 = name.ToLower();
Console.WriteLine(n1); // vishal

Console.WriteLine(name.Length); // 6

//string firstName = "Suraj";
//string lastName = "Sonawane";

string firstName = "Suraj", lastName = "Sonawane";

string fullName = firstName + " " + lastName;
Console.WriteLine(fullName); // Suraj Sonwane

fullName = string.Concat(firstName, lastName);
Console.WriteLine(fullName); // SurajSonwane

fullName = string.Concat(firstName, ",", lastName);
Console.WriteLine(fullName); // Suraj,Sonawane

fullName = string.Join(' ', firstName, lastName);
Console.WriteLine(fullName); // Suraj Sonwane

// Full Name : Suraj Sonawane
fullName = "Full Name : " + firstName + " " + lastName;
Console.WriteLine(fullName); // Full Name : Suraj Sonawane

Console.WriteLine($"Full Name: {firstName},{lastName}");

fullName = $"Employee Full Name : {firstName} {lastName}";
Console.WriteLine(fullName);

int i1 = firstName.IndexOf('S');
Console.WriteLine($"{firstName} : S - {i1}");

i1 = lastName.IndexOf('a');
Console.WriteLine($"{lastName} : a - {i1}");

i1 = lastName.LastIndexOf('a');
Console.WriteLine($"{lastName} : a - {i1}");

Console.WriteLine(firstName);
// *Suraj*
firstName = "*Suraj*";
Console.WriteLine(firstName);

// "Suraj"
firstName = "\"Suraj\"";
Console.WriteLine(firstName);

firstName = "'Suraj'";
Console.WriteLine(firstName);

// \Suraj\
firstName = "\\Suraj\\";
Console.WriteLine(firstName);

string filePath = "C:\\Users\\user\\Desktop\\Batch 21 Notes";
Console.WriteLine(filePath);

filePath = @"C:\Users\user\Desktop\Batch 21 Notes";
Console.WriteLine(filePath);

firstName = "Suraj";
Console.WriteLine($"{firstName} {lastName}"); // Suraj Sonawane
Console.WriteLine($"{firstName}\n{lastName}");
Console.WriteLine($"{firstName}\t{lastName}");

// Suraj Sonwane
// Suraj    Sonwane

string email = "suraj.shinde@gmail.com";
Console.WriteLine(email);
Console.WriteLine(email.Substring(0, 12));
Console.WriteLine(email.Substring(13, 9));

email = "suraj@gmail.com";
Console.WriteLine(email);
Console.WriteLine(email.Substring(0, email.IndexOf('@')));
Console.WriteLine(email.Substring(email.IndexOf('@') + 1, email.Length - email.IndexOf('@') - 1));

Console.ReadLine(); // to hold output screen 