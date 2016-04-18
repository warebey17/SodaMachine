using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaMachine
{
    class Quarter : Currency
    {
        Decimal quarters;
        public Quarter()
        {
            quarters = .25m;
        }
    }
}
