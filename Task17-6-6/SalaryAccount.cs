using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task17_6_6
{
    /// <summary>
    /// Зарплатный аккаунт
    /// </summary>
    public class SalaryAccount : BasicAccount
    {
        public override double CalculateInterest()
        {
            return Balance * 0.005;
        }
    }
}
