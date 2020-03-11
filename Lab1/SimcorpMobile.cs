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
        private readonly OLEDScreen vOLEDScreen = new OLEDScreen();
        public override BatteryBase Battery { get { return vBatterySimple; } }
        private readonly BatterySimple vBatterySimple = new BatterySimple();
        public override DynamicBase Dynamic { get { return vDynamicSimple; } }
        private readonly DynamicSimple vDynamicSimple = new DynamicSimple();
        public override KeyboardBase Keyboard { get { return vKeyboardWithLetters; } }
        private readonly KeyboardWithLetters vKeyboardWithLetters = new KeyboardWithLetters();
        public override MicrophoneBase Microphone { get { return vMicrophoneSimple; } }
        private readonly MicrophoneSimple vMicrophoneSimple = new MicrophoneSimple();
        public override SimCardBase SimCard{ get { return vSimcardSimple ; } }
        private readonly SimCardSimple vSimcardSimple= new SimCardSimple();

        public override void Call()
        {
            throw new NotImplementedException();
        }


        /*public void GetDescription()
        {
            Console.WriteLine("Here is description of mobile phone");
            Console.WriteLine("Phone has battery, dynamic, keyboard, microphone, screen, sim-card");
            Console.WriteLine("Press any key to close ... ");
            Console.ReadKey();
                }*/



    }
}
