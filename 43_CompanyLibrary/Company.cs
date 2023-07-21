public delegate bool PromoteCriteriaDel(Employee e);

public class Company
{
    public string Name { get; set; }
    private Employee[] _employees;

    public Company(string companyName, Employee[] employees)
    {
        Name = companyName;
        _employees = employees;
    }

    public void EmployeeNames()
    {
        Console.WriteLine($"*** Company Name {Name} ***");
        Console.WriteLine($"*** Total Employees {_employees.Length} ***");
        for (int i = 0; i < _employees.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {_employees[i].Name}");
        }
    }

    public void Promote(PromoteCriteriaDel del)
    {
        Console.WriteLine("*** Promoted Employees ***");
        for (int i = 0; i < _employees.Length; i++)
        {
            // if (_employees[i].Experience >= 3)
            if (del(_employees[i]))
            {
                Console.WriteLine($"{_employees[i].Name} is promoted");
            }
        }
    }
}