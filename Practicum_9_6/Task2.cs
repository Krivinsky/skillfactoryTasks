using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_9_6_1
{
     class Task2
    {
        public delegate ICollection<string> SortHandler(ICollection<string> item, int number);  // Объявляем делегат
        public static event SortHandler SortEvent; //Объявляем событие

        static void Main(string[] args)
        {
            Console.WriteLine("Ведте число 1 или 2. Для выхода введите - 0");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number != 0)
            {
                SortEvent += Sorting;
                ICollection<string> list = new List<string>() { "Иванов", "Петров", "Сидоров", "Кузнецов", "Васильев" };
                try
                {
                    if (number != 1 && number != 2) throw new MyException();

                    ICollection<string> result = SortEvent(list, number);

                    foreach (string item in result)
                    {
                        Console.WriteLine(item);
                    }
                }
                catch (MyException e)
                {
                    Console.WriteLine("Введено некоректное число");
                }
            }
        }

        public static ICollection<string> Sorting(ICollection<string> list, int number)
        {
            List<string> result = list.ToList();
            if (number == 1)
            {
                result.Sort();
            }
            if (number == 2)
            {
                result.Sort(Desc);  ///-----------------------------
            }
            return result;
        }

        private static int Desc(string x,
                            string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }

                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }

                else
                {
                    return y.CompareTo(x);
                }
            }
        }
    }
}


