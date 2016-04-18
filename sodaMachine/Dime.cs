using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaMachine
{
    class Dime : Currency
    {
        Decimal dimes;
        public Dime()
        {
            dimes = .10m;  
        }
    }
}
