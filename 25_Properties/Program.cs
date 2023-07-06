// top level statements

Student s1 = new Student();
s1.RollNumber = 10; // assign / set
s1.Age = 50;
Console.WriteLine($"Roll Number : {s1.RollNumber} Age : {s1.Age}"); // read/ get

Student s2 = new Student();
s2.RollNumber = -10; // assign / set
s2.Age = 5000;
Console.WriteLine($"Roll Number : {s2.RollNumber} Age : {s2.Age}"); // read/ get

Student s3 = new Student() { RollNumber = 1, Age= 20,Name = "Vishal"};
Console.WriteLine($"Roll Number : {s3.RollNumber} Age : {s3.Age} Name : {s3.Name}"); // read/ get

Student s4 = new Student() { RollNumber = 1, Age = 20, Name = null };
// s4.Passmark = 25; // it is read only
s4.Mobile = 8956890522;
Console.WriteLine($"Roll Number : {s4.RollNumber} Age : {s4.Age}" +
    $" Name : {s4.Name} Passmark : {s4.Passmark}"); // read/ get
// Console.WriteLine($"Mobile : {s4.Mobile}"); // it is write only property

Console.ReadLine();

class Student
{
    private int _rollNumber;
    private int _age;
    private string _name;
    private int _passmark = 40;
    private long _mobile;

    public int RollNumber
    {
        set
        {
            if (value > 0)
            {
                _rollNumber = value;
            }
            else
            {
                Console.WriteLine("Roll Number cannot be negative");
            }
        }
        get
        {
            return _rollNumber;
        }        
    }

    public int Age
    {
        get { return _age; }

        set
        {
            if(value >= 1 && value <= 150)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Age should be between 1 and 150");
            }
        }
    }

    public string Name
    {
        get
        {
            return !string.IsNullOrEmpty(_name) ? _name : "NO NAME";
        }
        set
        {
            _name = value;
        }
    }

    public int Passmark
    {
        get
        {
            return _passmark;
        }
    }

    public long Mobile
    {
        set
        {
            _mobile = value;
        }
    }

    private string _city;
    public string City
    {
        get { return _city; }
        set { _city = value; }
    }

    public string Email { get; set; }
}