using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17_6_6
{
    /// <summary>
    /// Базовый тип для всех аккаунтов
    /// </summary>
    abstract public class BasicAccount
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public abstract double CalculateInterest();
    }
}
