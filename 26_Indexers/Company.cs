public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}

public class Company
{
    public string CompanyName { get; set; }

    private Employee[] _employees;

    public string this[int id]
    {
        get
        {
            string name = "NOT FOUND";
            for(int i = 0; i < _employees.Length; i++)
            {
                Employee e = _employees[i];
                if(e.Id == id)
                {
                    name = e.Name;
                    break;
                }
            }
            return name;
        }

        set
        {
            for (int i = 0; i < _employees.Length; i++)
            {
                if (_employees[i].Id == id)
                {
                    _employees[i].Name = value;
                }
            }
        }
    }

    public Employee this[string name]
    {
        get
        {
            Employee e = null;

            for (int i = 0; i < _employees.Length; i++)
            {
                e = _employees[i];
                if (e.Name == name)
                {
                    return e;
                }
            }
            return e;
        }
    }

    public Company(Employee[] emps)
    {
        _employees = emps; 
    }
}