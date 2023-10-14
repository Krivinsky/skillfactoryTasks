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

        public ICollection<string> Sorting (ICollection<string> list)
        {
            
            
            return list;
        }

    }

    class Sort
    {
        delegate ICollection<T> SortHendler<T>(T item);
        SortHendler<string>? sortDelegate;

        public void Register
    }

}
