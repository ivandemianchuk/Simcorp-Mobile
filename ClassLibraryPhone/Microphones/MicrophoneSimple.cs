using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
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
