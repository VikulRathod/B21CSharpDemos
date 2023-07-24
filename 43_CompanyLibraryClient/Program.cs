class Program
{
    static void Main()
    {
        //Subject[] Subjects = new Subject[] 
        //{
        //Subject.Marathi, Subject.Hindi, Subject.English
        //};

        //for (int i = 0; i < Subjects.Length; i++)
        //{
        //    Console.Write($"{Subjects[i]} ");
        //}

        Employee[] employees = new Employee[]
{
new Employee(){Id = 1, Name = "Ramesh",
    Gender = "Male", Experience = 3, DepartmentName = "IT" },
new Employee(){Id = 2, Name = "Pandurang",
    Gender = "Male", Experience = 1, DepartmentName = "ADMIN" },
new Employee(){Id = 3, Name = "Kunal",
    Gender = "Male", Experience = 5, DepartmentName = "IT" },
new Employee(){Id = 4, Name = "Shruti",
    Gender = "Female", Experience = 3, DepartmentName = "IT" },
new Employee(){Id = 5, Name = "Payal",
    Gender = "Female", Experience = 2, DepartmentName = "HR" }
};

        Company tcs = new Company("TCS", employees);
        tcs.EmployeeNames();
        // PromoteCriteriaDel del1 = TCSPromoteCriteria;
        //PromoteCriteriaDel del1 = delegate (Employee e) {
        //    return e.Gender == "Female";
        //};
        //PromoteCriteriaDel del1 = (e) => {
        //    return e.Gender == "Female";
        //};
        //PromoteCriteriaDel del1 = e => {
        //    return e.Gender == "Female";
        //};
        Predicate<Employee> del1 = e => e.Gender == "Female";
        tcs.Promote(del1);

        Predicate<Employee> del = delegate (Employee e)
        {
            return e.DepartmentName == "HR";
        };
        tcs.Promote(del);

        // tcs.Promote(delegate (Employee e) { return e.Name.StartsWith("P"); });
        tcs.Promote(e => e.Name.StartsWith("P"));

        Employee[] wiproemployees = new Employee[]
        {
new Employee(){Id = 1, Name = "Vishal",
    Gender = "Male", Experience = 3, DepartmentName = "IT" },
new Employee(){Id = 2, Name = "Dipak",
    Gender = "Male", Experience = 1, DepartmentName = "ADMIN" },
new Employee(){Id = 3, Name = "Aniket",
    Gender = "Male", Experience = 5, DepartmentName = "IT" },
new Employee(){Id = 4, Name = "Priyanka",
    Gender = "Female", Experience = 3, DepartmentName = "IT" },
new Employee(){Id = 5, Name = "Snehal",
    Gender = "Female", Experience = 2, DepartmentName = "HR" }
        };

        Company wipro = new Company("WIPRO", wiproemployees);
        wipro.EmployeeNames();
        Predicate<Employee> del2 = WiproPromoteCriteria;
        wipro.Promote(del2);

        Console.ReadLine();
    }

    //public static bool TCSPromoteCriteria(Employee e)
    //{
    //    // return e.DepartmentName == "IT";
    //    return e.Gender == "Female";
    //}

    static bool WiproPromoteCriteria(Employee e)
    {
        // return e.DepartmentName == "ADMIN";
        return e.DepartmentName == "ADMIN" || e.DepartmentName == "HR";
    }
}

enum Subject
{
    Marathi, Hindi, English
}