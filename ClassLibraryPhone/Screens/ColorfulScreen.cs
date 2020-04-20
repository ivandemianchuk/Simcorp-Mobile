﻿using Lab.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class ColorfulScreen : ScreenBase
    {

        public ColorfulScreen()
        {
            vManufacturingTechnology = "Colorful";
            vResolution = new ScreenResolution(1200, 800);
        }
        public override void Show(IScreenImage image)
        {
            //here logic that draws colorful image can be added 
        }

        public override void Show(IScreenImage image, int brightness)
        {
            throw new NotImplementedException();
        }

    }
}
