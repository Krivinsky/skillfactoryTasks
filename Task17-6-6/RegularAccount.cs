using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task17_6_6
{
    /// <summary>
    /// Обычный аккаунт
    /// </summary>
    public class RegularAccount : BasicAccount
    {
        public override double CalculateInterest()
        {
            if (Balance < 1000)
                Interest = Balance * 0.002;

            if (Balance >= 1000)
                Interest = Balance * 0.004;

            return Interest;
        }
    }
}
