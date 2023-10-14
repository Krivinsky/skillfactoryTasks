using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_9_6_1
{
     class Task2
    {
        

        static void Main(string[] args)
        {
            ICollection<string> list = new List<string>()  { "Иванов", "Петров", "Сидоров", "Кузнецов", "Васильев" };



        }
    }

    public class Sort
    {
        // Объявляем делегат
        public delegate ICollection<string> SortHandler (ICollection<string> item);

        // Создаем переменную делегата
        public SortHandler? sortDelegate;

        // Регистрируем делегат
        public void RegisterHandler(SortHandler sortHandler)
        {
            sortDelegate = sortHandler;
        }

        public ICollection<string> Sorting(ICollection<string> list)
        {


            return list;
        }
    }

}
