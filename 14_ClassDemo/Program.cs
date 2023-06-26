class Program
{
    static void Main()
    {
        int rn = 1;
        string name = "Ramesh";
        string gender = "Male";
        long mobile = 8956890522;

        // Student s1; // null

        Student s1 = new Student(); // object / instance
        // reading: s1 is a reference variable of type Student pointing to
        // Student Object

        s1.FirstName = "Ramesh";
        s1.LastName = "Yadav";
        s1.PrintFullName();

        Student s2 = new Student();
        s2.FirstName = "Ritesh";
        s2.LastName = "Jadhav";
        s2.PrintFullName();

        // object initializer syntax
        Student s3 = new Student()
        {
            FirstName = "Paresh",
            LastName = "Desale"
        };
        s3.PrintFullName();

        Circle.Pi = 3.14f;

        Circle c1 = new Circle();
        c1.Radius = 5;
        // c1.Pi = 3.14f;
        c1.Area();

        // Circle c2 = new Circle() { Radius = 10, Pi = 3.14f};
        Circle c2 = new Circle() { Radius = 10 };
        c2.Area();

        Console.ReadLine();
    }
}

public class Student
{
    // fields 
    // global variable can be used anywhere inside class
    public string FirstName;
    public string LastName;

    // method
    public void PrintFullName()
    {
        Console.WriteLine($"Full Name : {FirstName} {LastName}");
    }
}

public class Circle
{
    public int Radius;
    public static float Pi;

    public void Area()
    {
        Console.WriteLine($"Area : {Pi * Radius * Radius} of a circle having radius : {Radius} ");
    }
}

