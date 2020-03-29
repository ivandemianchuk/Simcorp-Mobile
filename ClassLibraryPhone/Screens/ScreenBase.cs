using Lab2.Screens;
using System.Text;

namespace Lab2
{
    public abstract class ScreenBase
    {

        public ScreenBase()
        {
            vManufacturingTechnology = "Undefined";
            vResolution = new ScreenResolution(0, 0);
        }
        public abstract void Show(IScreenImage image);

        public abstract void Show(IScreenImage image, int brightness);
        public ScreenResolution Resolution { get { return vResolution; } }
        internal ScreenResolution vResolution;

        public string ManufacturingTechnology { get { return vManufacturingTechnology; } }
        internal string vManufacturingTechnology;

        public override string ToString()
        {

            var descriptionBuilder = new StringBuilder();

            descriptionBuilder.Append($"{ vManufacturingTechnology} +  Screen;");
            descriptionBuilder.Append($"Screen Resolution description:{vResolution.ToString()}");

            return descriptionBuilder.ToString();
        }

    }
}
