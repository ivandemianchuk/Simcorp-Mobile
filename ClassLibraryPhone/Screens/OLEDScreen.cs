using Lab2.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class OLEDScreen : ColorfulScreen
    {
        public OLEDScreen()
        {
            vManufacturingTechnology = "OLED";
            vResolution = new ScreenResolution(1920, 1280);
        }
        public override void Show(IScreenImage image)
        {
            //here logic for OLED screen can be added
        }

    }
}
