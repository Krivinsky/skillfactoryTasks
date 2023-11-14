namespace DelegatePractic
{
    class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = () =>
            {
                return new Random().Next(0, 100);
            };
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();
        }
    }


    class Program9_4_2
    {
        public delegate Car HandlerMethod();

        public delegate void HandlerDelegate(Lexus lexus);

        public static Car CarHandler()
        {
            return null;
        }

        public static Lexus LexusHandler()
        {
            return null;
        }

        public static void GetCar(Car car) { }


        HandlerMethod Handler = CarHandler;

        HandlerMethod Method = LexusHandler;

        HandlerDelegate handlerDelegate = GetCar;

    }

    public class Car { }

    public class Lexus : Car { }
}