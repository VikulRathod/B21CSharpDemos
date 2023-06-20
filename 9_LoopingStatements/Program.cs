#region Code Without loop

//Console.WriteLine("Welcome to V#");
//Console.WriteLine("Welcome to V#");
//Console.WriteLine("Welcome to V#");
//Console.WriteLine("Welcome to V#");
//Console.WriteLine("Welcome to V#");

//Console.ReadLine();

#endregion Code Without loop

#region while loop

//int start = 1; // Initializaiton
//while (start <= 12) // condition
//{
//    Console.WriteLine("Welcome to V#");
//    // start = start + 1;  start += 1;
//    start++; // updation
//}

//int start = 1;
//while(start <= 10)
//{
//    // Console.WriteLine(start);
//    Console.Write($"{start} ");
//    start++;
//}

//int start = 10;
//while (start >= 1)
//{
//    Console.Write($"{start} ");
//    start--;
//}

//int start = 10;
//while (start > 10)
//{
//    Console.Write($"{start} ");
//    start--;
//}

//Console.ReadLine();

#endregion while loop

#region do while loop

//int start = 1;
//do
//{
//    Console.WriteLine(start);
//    start++;
//} while (start <= 0);

// Console.ReadLine();

#endregion do while loop

#region for loop

//for (int start = 1;start <= 10;start++)
//{
//    Console.WriteLine(start);
//}

//int start = 1;
//for (; start <= 10;)
//{
//    Console.WriteLine(start);
//    start++;
//}

//for (int i = 1; i <= 10; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//for(int i = 2; i <= 10; i += 2)
//{
//    Console.WriteLine(i);
//}

//Console.ReadLine();

#endregion for loop

#region break & continue statement

//for (int i = 1; i <= 10 ; i++)
//{
//    if (i % 2 == 0)
//    {
//        break;
//    }

//    Console.Write($"{i} ");      
//}

//// break the loop without using break statement
//for (int i = 1; i <= 10; i++)
//{
//    Console.Write($"{i} ");
//    if (i == 5)
//    {
//        // break;
//        i = 10;
//    }    
//}

//for (int i = 1; i <= 10 ; i++)
//{
//    if(i == 2 && i == 5)
//    {
//        continue;
//    }

//    Console.Write($"{i} ");
//}

//Console.ReadLine();

#endregion break & continue statement

#region Do While loop example

// multi line comment => Ctrl + Shift + /

Console.WriteLine("Welcome to CCD!!!");
string choice = "";
int smallQuantity = 0, mediumQuantity = 0, largeQuantity = 0;
int input;

do
{
    Console.WriteLine("Please choose coffee size");
    Console.WriteLine("1 - Small 2 - Medium 3 - Large");

    if (int.TryParse(Console.ReadLine(), out input))
    {
        switch (input)
        {
            case 1:
                Console.WriteLine("You choosed: SMALL COFFEE");
                Console.WriteLine("How much?");
                smallQuantity += int.Parse(Console.ReadLine());
                break;
            case 2:
                Console.WriteLine("You choosed: MEDIUM COFFEE");
                Console.WriteLine("How much?");
                mediumQuantity += int.Parse(Console.ReadLine());
                break;
            case 3:
                Console.WriteLine("You choosed: LARGE COFFEE");
                Console.WriteLine("How much?");
                largeQuantity += int.Parse(Console.ReadLine());
                break;
            default:
                Console.WriteLine("INVALID CHOICE");
                break;
        }
    }
    else
    {
        Console.WriteLine("INVALID INPUT");
    }

    Console.WriteLine("Anything else, would you like to order?");
    choice = Console.ReadLine();
} while (choice == "yes" || choice == "y");

Console.WriteLine("**************** BILL RECEIPT *******************");

if (smallQuantity > 0)
{
    Console.WriteLine($"SMALL COFFEE : {smallQuantity} * 10 = {smallQuantity * 10}");
}
if (mediumQuantity > 0)
{
    Console.WriteLine($"MEDIUM COFFEE : {mediumQuantity} * 20 = {mediumQuantity * 20}");
}
if (largeQuantity > 0)
{
    Console.WriteLine($"LARGE COFFEE : {largeQuantity} * 30 = {largeQuantity * 30}");
}

Console.WriteLine($"TOTAL : {smallQuantity * 10 + mediumQuantity * 20 + largeQuantity * 30}");

Console.WriteLine("Thank You !!! Visit Again !!!");

Console.ReadLine();


#endregion Do While loop example