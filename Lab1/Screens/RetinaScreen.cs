using Lab1.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class RetinaScreen : ColorfulScreen
    {

        public RetinaScreen()
        {
            vManufacturingTechnology = "Retina";
            vResolution = new ScreenResolution(480, 600);
        }
        public override void Show(IScreenImage image)
        {
            //here logic for Retina screen can be added
        }

    }
}
