#region swap two numbers

//int i = 10, j = 20;

//Console.WriteLine($"i : {i} j : {j}");

////// using third variable
////int temp = i;
////i = j;
////j = temp;

//// without using third variable
//i = i + j; // i = 30
//j = i - j; // 10
//i = i - j; // 20


//Console.WriteLine($"i : {i} j : {j}");

#endregion swap two numbers

#region reverse string

//Console.WriteLine("Please enter name");
//string name = Console.ReadLine();

//Console.WriteLine($"Input : {name}");

//string reversedString = "";

//char[] inputs = name.ToCharArray();

//for (int i = inputs.Length - 1; i >= 0; i--)
//{
//    reversedString += inputs[i];
//}

//Console.WriteLine($"Output: {reversedString}");

#endregion reverse string

#region palindrome string

//Console.WriteLine("Please enter name");
//string name = Console.ReadLine();

//Console.WriteLine($"Input : {name}");

//string reversedString = "";

//char[] inputs = name.ToCharArray();

//for (int i = inputs.Length - 1; i >= 0; i--)
//{
//    reversedString += inputs[i];
//}

//if(name == reversedString)
//{
//    Console.WriteLine("PALINDROME");
//}
//else
//{
//    Console.WriteLine("NOT PALINDROME");
//}

#endregion palindrome string


#region reverse sentence

//// input: how are you
//// output: you are how

//Console.WriteLine("Please enter a sentence");
//string input = Console.ReadLine();

//string[] words = input.Split(' ');
//string output = "";

//for (int i = words.Length - 1; i >= 0; i--)
//{
//    output += words[i] + " ";
//}

//Console.WriteLine($"Input: {input}");
//Console.WriteLine($"Output: {output}");

#endregion reverse sentence


#region reverse string of each words in a sentence

// input how are you
// output woh era uoy

//using System;

//Console.WriteLine("Please enter a sentence");
//string input = Console.ReadLine();

//string[] words = input.Split(' ');

//Console.Write("Output: ");
//for (int i = 0; i < words.Length; i++)
//{
//    string revWord = "";
//    char[] word = words[i].ToCharArray();
//    for (int j = word.Length - 1; j >= 0; j--)
//    {
//        revWord += word[j];
//    }
//    Console.Write($"{revWord} ");
//}

#endregion reverse string of each words in a sentence

for (int i = 1; i <= 5; i++)
{
    for (int m = 1; m <= 5; m++)
    {
        if (i == m)
        {
            Console.Write($"{m}\t");

        }
        else
        {
            Console.Write(" \t");
        }
    }

    Console.WriteLine();
}

Console.ReadLine();