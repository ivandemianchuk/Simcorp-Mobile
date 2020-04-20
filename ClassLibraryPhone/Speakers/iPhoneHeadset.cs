using Lab;
using System;

namespace Lab.Speakers
{
    public class iPhoneHeadset : IPlayback
    {
        private IOutput Output;
        
        public iPhoneHeadset(IOutput output)
        {
            Output = output;
        }
        public iPhoneHeadset()
        {

        }
        public void Play(object data)
        {
            Output.WriteLine($"{nameof(iPhoneHeadset)} sound");
        }
        public override string ToString()
        {
            return "iPhone headset";
        }
    }
}
