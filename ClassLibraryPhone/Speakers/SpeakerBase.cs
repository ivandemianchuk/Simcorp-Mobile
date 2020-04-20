using Lab.Speakers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public abstract class SpeakerBase : IPlayback
    {
        private IOutput Output;
        public SpeakerBase(IOutput output)
        {
            Output = output;
        }
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

        public virtual void Play(object data)
        {
            Output.WriteLine($"{nameof(SpeakerBase)} sound");
        }
    }
}
