class Program
{
    static void Main()
    {
        Student s1 = new Student();
        // s1.RollNumber = 1; // assign/ set
        s1.SetRollNumber(1);
        //s1.Name = "Vishal";
        s1.SetName("Vishal");
        // Console.WriteLine($"Roll Number : {s1.RollNumber}"); // read/ get
        // Console.WriteLine($"Roll Number : {s1.GetRollNumber()} Name: {s1.Name}"); // read/ get
        Console.WriteLine($"Roll Number : {s1.GetRollNumber()} Name: {s1.GetName()}"); // read/ get

        Student s2 = new Student();
        // s2.RollNumber = -1; // assign/ set
        s2.SetRollNumber(-1); // assign/ set
        // s1.Name = null;
        s1.SetName(null);
        // Console.WriteLine($"Roll Number : {s2.RollNumber}"); // read/ get
        // Console.WriteLine($"Roll Number : {s2.GetRollNumber()} Name: {s1.Name}"); // read/ get
        Console.WriteLine($"Roll Number : {s2.GetRollNumber()} Name: {s1.GetName()}"); // read/ get

        Console.ReadLine();
    }
}

class Student
{
    private int RollNumber;
    private string Name;

    public void SetRollNumber(int rn)
    {
        if (rn > 0)
        {
            RollNumber = rn;
        }
        else
        {
            Console.WriteLine("Roll Number cannot be negative");
        }
    }

    public int GetRollNumber()
    {
        return RollNumber;
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return !string.IsNullOrEmpty(Name) ? Name : "No Name";
    }
}