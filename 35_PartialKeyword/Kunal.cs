// Kunal

public partial class Student : Course
{
    // public Student(){}
    private string _city;
    public int RollNumber { get; set; }
    public string Name { get; set; }

    // protected void Duplicate() { }

    
}

interface IStudent
{
    void Print();
}

public class Course { }
public class Institute { }