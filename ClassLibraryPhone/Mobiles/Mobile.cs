using ClassLibraryPhone.Messages;
using Lab.Batteries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.Speakers;

namespace Lab
{
    public abstract class Mobile
    {
        public SMSProvider MyProperty { get; set; }
        public abstract ScreenBase Screen{ get; }
        public abstract SpeakerBase Speaker { get; }

        public abstract BatteryBase Battery { get; }
        
        public abstract KeyboardBase Keyboard { get; }
        public abstract MicrophoneBase Microphone { get; }

       public abstract SimCardBase SimCard { get; }

        public abstract void Call();

        public IPlayback PlaybackComponent { get; set; }

        public void Play(object data)
        {
            PlaybackComponent.Play(data);
        }

        public ICharger ChargerComponent { get; set; }

        public void Charge(ICharger ChargerComponent)
        {
            ChargerComponent.Charge(Battery);
        }

        public override string ToString()
        {

            var descriptionBuilder = new StringBuilder();

            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Dynamic Type: {Speaker.ToString()}");
            descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Keyboard Type: {Keyboard.ToString()}");
            descriptionBuilder.AppendLine($"Microphone Type: {Microphone.ToString()}");
            descriptionBuilder.AppendLine($"Simcard Type: {SimCard.ToString()}");

            return descriptionBuilder.ToString();
        }


        private void Show(IScreenImage image)
        {
            Screen.Show(image);
        }
    }
}
