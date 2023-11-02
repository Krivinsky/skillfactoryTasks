using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_10_5_1
{
    class Calculator : ICalculateble
    {
        ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public int addition(int a, int b)
        {
            Logger.Event("Операция сложения");
            return a + b;
        }
    }

    interface ICalculateble
    {
        int addition(int a, int b);
    }
}
