static void Main()
{
    int i = 10; // value type variable
     
    object o = new object(); // reference type variable
    o = 10;

    int j = 10;
    object o1 = j; // int => object  // boxing
    Console.WriteLine(o1);

    int k = (int)o1; // object => int // unboxing
    Console.WriteLine(k); 
}

