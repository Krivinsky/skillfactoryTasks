
class Program
{
    static ILogger Logger { get; set; }

    static void Main(string[] args)
    {
        Logger = new Logger();
        Calculator calculator = new Calculator(Logger);
        Console.WriteLine("Добро пожаловать в мини-калькулятор, который будет подсчитывать сумму двух чисел. \n Ведите первое число");
        try
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат - " + calculator.addition(a, b));
        } 
        catch (Exception ex)
        {
            Console.WriteLine("Введено некорректное число");
        }

    }
}


class Calculator : ICalculateble
{
    ILogger Logger { get; }

    public Calculator(ILogger logger)
    {
        Logger = logger;
    }
    
    public int addition(int a, int b)
    {
        
        return a + b;
    }
}

interface ICalculateble
{
    int addition (int a, int b);
}

interface ILogger
{
    void Event(string str);
    void Error(string str);
}

public class Logger : ILogger
{
    public void Error(string str)
    {
        Console.WriteLine(str);
    }

    public void Event(string str)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(str);
    }
}

