using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class MicrophoneSimple : MicrophoneBase
    {
        public MicrophoneSimple()
        {
            vMicrophoneType = "Simple";
        }

        public override void Record()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Microphone " + vMicrophoneType;
        }
    }
}
