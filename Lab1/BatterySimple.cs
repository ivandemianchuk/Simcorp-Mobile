using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class BatterySimple :BatteryBase
    {
        public void Charge()
        {
            if (ChargePercents < 100)
            {
                ChargePercents = 100;
            }
        }
        public override string ToString()
        {
            return "Battery Simple";
        }
    }
}
