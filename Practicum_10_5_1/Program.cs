namespace Practicum_10_5_1
{

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
                Logger.Event("Результат - " + calculator.addition(a, b));
            }
            catch (Exception ex)
            {
                Logger.Error("Введено некорректное значение");

            }

        }
    }
}