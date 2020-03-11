using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class DynamicBase 
    {
        public DynamicBase()
        {
            Volume = 0;
        }
       DynamicBase(int volume)
        {
            Volume = volume;
        }
        public int Volume { get; set; }



        
    }
}
