using My_Calculator;

class Program
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.Write("Enter first number (A): ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Enter second number (B): ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Enter operation (+, -, *, /): ");
        char op = Console.ReadLine()![0];

        try
        {
            var calc = new Calculator(a, b, op);
            Console.WriteLine($"Result: {calc.Calculate()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}