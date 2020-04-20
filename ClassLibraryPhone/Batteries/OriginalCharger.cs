using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Batteries
{
    public class OriginalCharger:ICharger
    {
        private IOutput Output;

        public OriginalCharger()
        {

        }
        public OriginalCharger(IOutput output)
        {
            Output = output;
        }

        public void Charge(BatteryBase battery)
        {
            battery.Charge();
            Output.WriteLine("Charging battery");
        }

        public override string ToString()
        {
            return "Original Charger";
        }
    }
}
