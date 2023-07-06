
string[] names = new string[] { "Dipak", "Kunal", "Ramesh", "Ritesh" };
string name = names[2];
Console.WriteLine(name); // Ramesh

name = names[1];
Console.WriteLine(name); // Kunal

Employee e1 = new Employee() { Id = 100, Name = "Vishal", City = "Pune" };
Employee[] employees = new Employee[]
{
    e1,
new Employee(){ Id = 101, Name = "Dipak", City = "Mumbai"},
new Employee(){ Id = 102, Name = "Mahesh", City = "Pune"},
new Employee(){ Id = 103, Name = "Sachin", City = "Kalyan"},
new Employee(){ Id = 104, Name = "Suhas", City = "Yavatmal"}
};

Company tcs = new Company(employees);

string ename = tcs[100]; // Id as index => name return 
Console.WriteLine($"100 Id is employee name is : {ename}"); // Vishal

ename = tcs[103]; // Id as index => name return 
Console.WriteLine($"103 Id is employee name is : {ename}"); // Sachin

tcs[103] = "Kunal"; // assigning

ename = tcs[103]; // Id as index => name return 
Console.WriteLine($"103 Id is employee name is : {ename}"); // Kunal


ename = tcs[110]; // Id as index => name return 
Console.WriteLine($"110 Id is employee name is : {ename}"); // NOT FOUND

Employee e = tcs["Dipak"];
if(e != null)
{
    Console.WriteLine($"Employee Name : {e.Name} ID : {e.Id} City : {e.City}");
}

string sname = "Vishal";
char a = sname[0]; // V

Console.ReadLine();

