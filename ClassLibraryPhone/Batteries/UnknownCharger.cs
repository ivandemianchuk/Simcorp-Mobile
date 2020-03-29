using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Batteries
{
    public class UnknownCharger:ICharger
    {
        private IOutput Output;

        public UnknownCharger()
        {

        }
        public UnknownCharger(IOutput output)
        {
            Output = output;
        }

        public void Charge(BatteryBase battery)
        {
            battery.Charge();
            Console.WriteLine("Charging battery");
        }

        public override string ToString()
        {
            return "Unknown Charger";
        }
    }
}
