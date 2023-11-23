using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_15_2_8
{
    internal class Program
    {
        static string input;


        static void Main(string[] args)
        {

            List<int> list = new List<int>();

            while (input != "выход")
            {
                Console.WriteLine("Введите число или \"выход\" что бы выйти");

                input = Console.ReadLine();

                if (Int32.TryParse(input, out int number))
                {
                    list.Add(number);
                    Console.WriteLine("количество чисел в списке - " + list.Count);
                    Console.WriteLine("сумма всех чисел списка - " + list.Aggregate((x, y) => x + y));
                    Console.WriteLine("наибольшее число - " + list.Max());
                    Console.WriteLine("наименьшее число - " + list.Min());
                    Console.WriteLine("среднее значение - " + list.Average());
                    Console.WriteLine("***********************");
                }
                
            }
        }



    }
}