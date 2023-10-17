using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_10_5_1
{
    public class Logger : ILogger
    {
        public void Error(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(str);
        }

        public void Event(string str)
        {
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(str);
        }
    }

    interface ILogger
    {
        void Event(string str);
        void Error(string str);
    }

}
