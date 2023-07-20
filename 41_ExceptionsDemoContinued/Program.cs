
//Calculator c1 = new Calculator();
//Console.WriteLine(c1.Sample());

string name = null;
if(name != null)
    Console.WriteLine(name.ToUpper());

int num = 0;
int den = 0;

try
{
    Console.WriteLine("Welcome to Calculator App");
    Console.WriteLine("Please enter numerator");
    // num = int.Parse(Console.ReadLine());

    if(int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Please enter denominator");
        if (int.TryParse(Console.ReadLine(), out den))
        {
            if(den > 0)
            {
                Calculator c = new Calculator();
                c.Division(num, den);
            }
            else
            {
                Console.WriteLine("Denominator cannot be zero.");
            }
        }
        else
        {
            Console.WriteLine("Please enter correct denominator value");
        }
    }
    else
    {
        Console.WriteLine("Please enter correct numerator value");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();


class Calculator
{
    public void Division(int num, int den)
    {
        try
        {
            int div = num / den;
            Console.WriteLine($"Division {num} / {den} = {div}");
            // throw new Exception("My custom thrown exception");
        }
        catch (Exception ex)
        {
            throw;
            // throw new Exception("My custom thrown exception");
            // Console.WriteLine(ex.Message);
        }
    }

    public string Sample()
    {
        string result = "";
        try
        {
            result = "TRY";
            //throw new Exception("Error");
            //return "Try";
            // return result;
        }
        catch
        {
            result = "CATCH";
            // return result;
            // return "Catch";
        }
        finally
        {
            result = "FINALLY";
            // return "Finally";
        }
        
        return result;
    }
}