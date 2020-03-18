using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class BatteryBase
    {
        public int Capacity { get { return vCapacity; }}
        private int vCapacity;

        public int MaxCapacity { get { return vMaxCapacity; } }
        private int vMaxCapacity; 
        public BatteryBase()
        {
            vCapacity = vMaxCapacity;
        }
        public void Charge()
        {
            if (vCapacity < vMaxCapacity)
            {
                vCapacity = vMaxCapacity;
            }
        }

    }
}
