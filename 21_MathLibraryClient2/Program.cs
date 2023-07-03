using Calucations;

Console.WriteLine("Client 2 Project");

Calculator c1 = new Calculator();
int result = c1.Add(10, 10);
Console.WriteLine($"Addition : {result}");

result = c1.Division(150, 10);
Console.WriteLine($"Division : {result}");

Console.ReadLine();