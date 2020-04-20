using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class PhoneSpeaker :  SpeakerBase
    {
        private IOutput Output;
        public PhoneSpeaker()
        {

        }
        public PhoneSpeaker(IOutput output)
        {
            Output = output;
        }
        

        public override string ToString()
        {
            return "Phone Speaker";
        }
        public override void Play(object data)
        {
            Output.WriteLine($"{nameof(PhoneSpeaker)} sound");
        }
    }
}
