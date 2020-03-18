using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class KeyboardBase
    {
        public List<int> Numbers { get { return vNumbers; } }
        private List<int> vNumbers;
    }
}
