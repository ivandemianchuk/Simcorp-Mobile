using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Screens
{
    public class ScreenResolution
    {
        public ScreenResolution(int horizontalPixels, int verticalPixels)
        {
            vHorizontalPixels = horizontalPixels;
            vVerticalPixels = verticalPixels;
        }
        private int vHorizontalPixels;
        private int vVerticalPixels;

        public int HorizontalPixels{ get { return vHorizontalPixels; } }
        public int VerticalPixels { get { return vVerticalPixels; } }

        public override string ToString()
        {
            return $" {vHorizontalPixels}x{vVerticalPixels}";
        }
    }
}
