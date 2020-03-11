using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class BatteryBase
    {
        public int ChargePercents { get; set; }
        public BatteryBase()
        {
            ChargePercents = 100;
        }

    }
}
