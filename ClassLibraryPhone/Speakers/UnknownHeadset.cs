using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Speakers
{
    public class UnknownHeadset : IPlayback
    {
        private IOutput Output;
        public UnknownHeadset()
        {

        }
        public UnknownHeadset(IOutput output)
        {
            Output = output;
        }
        public void Play(object data)
        {
            Output.WriteLine($"{nameof(UnknownHeadset)} sound");
        }

        public override string ToString()
        {
            return "Unknown headset";
        }
    }
}
