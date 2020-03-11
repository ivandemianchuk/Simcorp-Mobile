using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class OLEDScreen : ColorfulScreen
    {
        public override void Show(IScreenImage image)
        {
            //here logic for OLED screen can be added
        }

        public override string ToString()
        {
            return "OLED Screen";
        }

    }
}
