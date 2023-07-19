int num = 0;
int den = 0;

try
{
    Console.WriteLine("Welcome to Calculator App");
    Console.WriteLine("Please enter numerator");
    num = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter denominator");
    den = int.Parse(Console.ReadLine());
}
//catch(FormatException ex)
//{
//    Console.WriteLine("Please enter a valid number");
//}
//catch(OverflowException ex)
//{
//    Console.WriteLine($"Please enter a number between {int.MinValue} and {int.MaxValue}");
//}
catch (Exception ex)
{
    Console.WriteLine($"Type: {ex.GetType().Name} Message: {ex.Message}");
    // Console.WriteLine("There is some error. Contact admin");
}

try
{
    Calculator c = new Calculator();
    c.Division(num, den);
}
catch
{
    Console.WriteLine("Exception in Main() method");
}

Console.WriteLine("Thank You ! Visit Again !!!");

Console.ReadLine();

class Calculator
{
    public void Division(int num, int den)
    {
        try
        {
            if (den != 0)
            {
                int div = num / den;
                Console.WriteLine($"Division {num} / {den} = {div}");
            }
            else
            {
                Console.WriteLine("Denominator cannot be zero.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Message : {ex.Message}");
            Console.WriteLine($"Stack Trace : {ex.StackTrace}");
            // Console.WriteLine("There is some error. Please try later.");
            //File.WriteAllText(@"E:/temp/batch21/errors/log.txt",
            //    $"Error found @{DateTime.Today}");
        }
        finally
        {
            Console.WriteLine("Division Operation Completed");
        }
    }
}