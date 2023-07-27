//// early binding
//Customer c = new Customer();
//c.Print();

// late binding
using System.Reflection;

Assembly assembly = Assembly.GetExecutingAssembly(); // fetching assembly
Type customerType = assembly.GetType("Customer"); // fetching type
Console.WriteLine($"Type Name : {customerType.Name}");

object c = Activator.CreateInstance(customerType); // creating instance of type

MethodInfo print = customerType.GetMethod("Print");
print.Invoke(c, null);

MethodInfo printA = customerType.GetMethod("PrintA");
printA.Invoke(null, null);

MethodInfo printB = customerType.GetMethod("PrintB");
printB.Invoke(c, new object[] { "Vishal" });

MethodInfo fullname = customerType.GetMethod("GetFullName");
string fn = fullname.Invoke(c, new object[] { "Vishal", "Pawar" }).ToString();
Console.WriteLine(fn);

// all methods
MethodInfo[] methods = customerType.GetMethods();
Console.WriteLine($"Method Count Inside Customer : {methods.Length}");
foreach (MethodInfo method in methods)
{
    Console.WriteLine($"method name : {method.ReturnType} {method.Name}");
}

// all properties
PropertyInfo[] properties = customerType.GetProperties();
Console.WriteLine($"Number of Properties : {properties.Length}");
foreach (PropertyInfo prop in properties)
{
    Console.WriteLine($"{prop.PropertyType} {prop.Name}");
}

// calling private method
MethodInfo secureMethod = customerType.GetMethod("SecureMethod",BindingFlags.NonPublic | BindingFlags.Instance);
secureMethod.Invoke(c, null);

Console.ReadLine();

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    private void SecureMethod()
    {
        Console.WriteLine("private SecureMethod() method called");
    }

    public void Print()
    {
        Console.WriteLine("Customer Print() Method");
    }

    public static void PrintA()
    {
        Console.WriteLine("Customer PrintA() Method");
    }

    public void PrintB(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }

    public string GetFullName(string fn, string ln)
    {
        return $"Full Name : {fn} {ln}";
    }
}