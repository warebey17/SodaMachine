using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaMachine
{
    class Penny : Currency
    {
        Decimal pennies;
        public Penny()
        {
            pennies = .01m;
        }
    }
}
