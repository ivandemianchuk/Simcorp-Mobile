using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public abstract class MicrophoneBase
    {
        public string MicrophoneType { get { return vMicrophoneType; } }
        internal string vMicrophoneType;
        public abstract void Record();

        public MicrophoneBase()
        {
            vMicrophoneType = "Base";
        }
    }
}
