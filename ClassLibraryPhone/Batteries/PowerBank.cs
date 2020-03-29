using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Batteries
{
    public class PowerBank : ICharger
    {
        private IOutput Output;
        public int Capacity { get { return vCapacity; } }
        private int vCapacity;

        public int MaxCapacity { get { return vMaxCapacity; } }
        private int vMaxCapacity;

        public void Charge(BatteryBase battery)
        {
            if ((battery.MaxCapacity - battery.Capacity)<vCapacity)
            {
                battery.Charge();
                vCapacity = vCapacity - (battery.MaxCapacity - battery.Capacity);
                Output.WriteLine("Charging battery");
            }
            else
            {
                Output.WriteLine("Battery cannot be charged");
            }
        }

        public PowerBank(int maxCapacity)
        {
            vMaxCapacity = maxCapacity;
            vCapacity = vMaxCapacity;
        }
        public PowerBank()
        {
            vMaxCapacity = 1000;
            vCapacity = 500;
        }
        public PowerBank(IOutput output)
        {
            vMaxCapacity = 1000;
            vCapacity = 500;
            Output = output;
        }

        public override string ToString()
        {
            return "PowerBank";
        }
    }
}
