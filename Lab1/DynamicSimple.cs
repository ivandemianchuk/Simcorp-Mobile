using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class DynamicSimple :  DynamicBase
    {
       public void ChangeVolume(int volume)
        {
            Volume = volume;
        }

        public override string ToString()
        {
            return "Dynamic Simple";
        }


    }
}
