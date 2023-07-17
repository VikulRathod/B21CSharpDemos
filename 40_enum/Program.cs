#region 1. Normal Code

//Student s1 = new Student();
//s1.RollNumber = 10;
//s1.Name = "Vishal";
//s1.Subject = "Maths";

//s1.Details();

//Student s2 = new Student();
//Console.WriteLine("Enter Roll Number");
//s2.RollNumber = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter Name");
//s2.Name = Console.ReadLine();
//Console.WriteLine("Enter Subject");
//s2.Subject = Console.ReadLine();

//s2.Details();

//Console.ReadLine();


//// Subject : Marathi, Hindi, English, Physics, Chemistry, Mathematics

//class Student
//{
//    public int RollNumber { get; set; }
//    public string Name { get; set; }
//    public string Subject { get; set; }

//    public void Details()
//    {
//        Console.WriteLine($"Roll Number : {RollNumber} Name : {Name} Subject : {Subject}");
//    }
//}

#endregion 1. Normal Code

#region 2. Integral Constants

//Student s1 = new Student();
//s1.RollNumber = 10;
//s1.Name = "Vishal";
//s1.Subject = 3;
//s1.Details();

//Student s2 = new Student();
//s2.RollNumber = 11;
//s2.Name = "Mahesh";
//s2.Subject = 5;


//Console.ReadLine();


//// documentation
//// 1 = Marathi, 2 = Hindi, 3 = English, 4 - Physics, 5 -Chemistry, 6 - Maths
//class Student
//{
//    public int RollNumber { get; set; }
//    public string Name { get; set; }
//    public int Subject { get; set; }

//    public void Details()
//    {
//        Console.WriteLine($"Roll Number : {RollNumber} Name : {Name} " +
//            $"Subject : {GetSubject(Subject)}");
//    }

//    private string GetSubject(int subject)
//    {
//        switch (subject)
//        {
//            case 1: return "Marathi";
//            case 2: return "Hindi";
//            case 3: return "English";
//            case 4: return "Physics";
//            case 5: return "Chemistry";
//            case 6: return "Mathematics";
//            default: return "Invalid Subject";
//        }
//    }
//}

#endregion 2. Integral Constants

#region 3. enum

//Student s1 = new Student();
//s1.RollNumber = 10;
//s1.Name = "Vishal";
//s1.Subject = Subject.Mathematics;
//s1.Details();


//Console.ReadLine();

//class Student
//{
//    public int RollNumber { get; set; }
//    public string Name { get; set; }
//    // public int Subject { get; set; }
//    public Subject Subject { get; set; }

//    public void Details()
//    {
//        Console.WriteLine($"Roll Number : {RollNumber} Name : {Name} " +
//            $"Subject : {Subject}");
//    }
//}

//enum Subject
//{
//    Marathi,
//    Hindi,
//    English,
//    Physics,
//    Chemistry,
//    Mathematics
//}

#endregion 3. enum

#region enum Vs Enum

Student s1 = new Student();
s1.RollNumber = 10;
s1.Name = "Vishal";
s1.Subject = Subject.Chemistry;
s1.Details();

// enum underlying type
Type t = Enum.GetUnderlyingType(typeof(Subject));
Console.WriteLine(t.Name);

string[] names = Enum.GetNames(typeof(Subject));
for (int i = 0; i < names.Length; i++)
{
    Console.Write($"{names[i]} ");
}

Console.WriteLine(); // new line

int[] values = (int[])Enum.GetValues(typeof(Subject));
for (int i = 0; i < values.Length; i++)
{
    Console.Write($"{values[i]} ");
}

Console.WriteLine();

Console.ReadLine();

class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    // public int Subject { get; set; }
    public Subject Subject { get; set; }

    public void Details()
    {
        Console.WriteLine($"Roll Number : {RollNumber} Name : {Name} " +
            $"Subject : {Subject}");
    }
}

// enum Subject : byte // to change underlying type
enum Subject
{
    Marathi = 10,
    Hindi,
    English,
    Physics,
    Chemistry,
    Mathematics = 17,
    Algebra
}


#endregion enum Vs Enum