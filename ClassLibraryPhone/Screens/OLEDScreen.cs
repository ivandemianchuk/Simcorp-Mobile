using Lab.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
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
