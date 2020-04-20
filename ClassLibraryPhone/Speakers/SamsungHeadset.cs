using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Speakers
{
    public class SamsungHeadset : IPlayback
    {
        private IOutput Output;

        public SamsungHeadset()
        {

        }
        public SamsungHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            Output.WriteLine($"{nameof(SamsungHeadset)} sound");
        }

        public override string  ToString()
        {
            return "Samsung headset";
        }
    }
}
