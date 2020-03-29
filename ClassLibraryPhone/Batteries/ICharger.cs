using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Batteries
{
    public interface ICharger
    {
        void Charge(BatteryBase battery);
    }
}
