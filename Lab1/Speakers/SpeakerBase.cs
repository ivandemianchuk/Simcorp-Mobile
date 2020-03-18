using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class SpeakerBase 
    {
        public SpeakerBase()
        {
            vVolume = 0;
        }
       SpeakerBase(int volume)
        {
            vVolume = volume;
        }
        public int Volume { get { return vVolume; } }
        private int vVolume;


        
    }
}
