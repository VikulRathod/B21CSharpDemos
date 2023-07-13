// Ramesh

partial class Student
{
    public Student()
    {
        // partial method call
        GetStudent(10);
        //Student result =  GetStudent(10);
        // code based on result
        // code based on result
    }
    public void Insert()
    {
        // database logic
        Console.WriteLine("Student Inserted Successfully");
    }

    public string City
    {
        get { return _city; }
        set
        {
            _city = value;
        }
    }

    // internal void Duplicate() { }

    partial void GetStudent(int rollNumber);

    partial void GetStudent(int rollNumber)
    {
        Console.WriteLine("Partial GetStudent() method");
    }
}