﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class ColorfulScreen : ScreenBase
    {
        public override void Show(IScreenImage image)
        {
            //here logic that draws colorful image can be added 
        }

        public override void Show(IScreenImage image, int brightness)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Colorful Screen";
        }
    }
}
