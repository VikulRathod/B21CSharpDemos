class Program
{
    static void Main()
    {
        //Console.WriteLine("HELLO"); // to write on console screen
        //Console.ReadLine(); // to read from console screen

        Console.WriteLine("Welcome to Calculator APP !!!");

        string choice = "";
        do
        {
            Console.WriteLine("Please enter first number");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter operation symbol");
            char op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"Result: {n1} + {n2} = {n1 + n2}");
                    break;
                case '-':
                    Console.WriteLine($"Result: {n1} - {n2} = {n1 - n2}");
                    break;
                case '*':
                    Console.WriteLine($"Result: {n1} * {n2} = {n1 * n2}");
                    break;
                case '/':
                    Console.WriteLine($"Result: {n1} / {n2} = {n1 / n2}");
                    break;
                default:
                    Console.WriteLine($"Operation does not supported");
                    break;
            }
            Console.WriteLine("Do you want to continue?");
            choice = Console.ReadLine();
        } while (choice == "yes" || choice == "y");

        Console.WriteLine("Thank you ! Visit Again !!!");

        Console.ReadLine(); // hold output screen
    }
}