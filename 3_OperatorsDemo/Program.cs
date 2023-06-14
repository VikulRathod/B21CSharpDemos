int i1 = 10, i2 = 10;
Console.WriteLine(i1); // 10

bool b1 = i1 == i2;
Console.WriteLine(b1); // true

b1 = i1 != i2;
Console.WriteLine(b1); // false

b1 = i1 <= i2;
Console.WriteLine(b1); // true

Console.WriteLine(i1); // 10
// i1 = i1 + 1;
// i1++;
// Console.WriteLine(i1++); // 10
Console.WriteLine(++i1); // 11

Console.WriteLine(i1); // 11

// i1 = i1 + 10;
i1 += 10;
Console.WriteLine(i1); // 21

i1 = 10;
i2 = 20;
int i3 = 30;

b1 = i1 < i2 && i2 < i3;
Console.WriteLine(b1); // True

b1 = i1 < i2 && i2 > i3;
Console.WriteLine(b1); // False

b1 = i1 < i2 || i2 > i3;
Console.WriteLine(b1); // True

int x = 27, y = 2;
int div = x / y;
Console.WriteLine(div); // 2

int rem = x % y;
Console.WriteLine(rem); // 1


Console.ReadLine();
