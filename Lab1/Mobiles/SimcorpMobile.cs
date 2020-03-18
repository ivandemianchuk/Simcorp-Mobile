using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class SimcorpMobile : Mobile
    {

        public override ScreenBase Screen { get { return vOLEDScreen; } }
        public override BatteryBase Battery { get { return vBatterySimple; } }
        public override SpeakerBase Dynamic { get { return vDynamicSimple; } }
        public override KeyboardBase Keyboard { get { return vKeyboardWithLetters; } }
        public override MicrophoneBase Microphone { get { return vMicrophoneSimple; } }
        public override SimCardBase SimCard { get { return vSimcardSimple; } }
        public SimcorpMobile()
        {
            vOLEDScreen = new OLEDScreen();
            vBatterySimple = new BatterySimple();
            vDynamicSimple = new SpeakerSimple();
            vKeyboardWithLetters = new KeyboardWithLetters();
            vMicrophoneSimple = new MicrophoneSimple();
            vSimcardSimple = new SimCardSimple();
        }
        private readonly OLEDScreen vOLEDScreen;
        private readonly BatterySimple vBatterySimple;
        private readonly SpeakerSimple vDynamicSimple;
        private readonly KeyboardWithLetters vKeyboardWithLetters;
        private readonly MicrophoneSimple vMicrophoneSimple;
        private readonly SimCardSimple vSimcardSimple;

        public override void Call()
        {
            throw new NotImplementedException();
        }
    }

    }

   
