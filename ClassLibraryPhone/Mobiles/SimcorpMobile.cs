using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPhone.Messages;
using static ClassLibraryPhone.Messages.SMSProvider;

namespace Lab
{
    public class SimcorpMobile : Mobile
    {

        public override ScreenBase Screen { get { return vOLEDScreen; } }
        public override BatteryBase Battery { get { return vBatterySimple; } }
        public override SpeakerBase Speaker { get { return vPhoneSpeaker; } }
        public override KeyboardBase Keyboard { get { return vKeyboardWithLetters; } }
        public override MicrophoneBase Microphone { get { return vMicrophoneSimple; } }
        public override SimCardBase SimCard { get { return vSimcardSimple; } }

        public override MessageStorage Messages { get { return vMessages; } }
        public override SMSProvider Provider { get { return vProvider; } }

        public SimcorpMobile()
        {
            vOLEDScreen = new OLEDScreen();
            vBatterySimple = new PhoneBattery();
            vPhoneSpeaker = new PhoneSpeaker();
            vKeyboardWithLetters = new KeyboardWithLetters();
            vMicrophoneSimple = new MicrophoneSimple();
            vSimcardSimple = new SimCardSimple();
            vMessages = new MessageStorage();
            vProvider = new SMSProvider();
        }

        public override void StartSendMessages(int count)
        {
            vProvider.SMSReceived += new SMSReceivedDelegate(Messages.AddMessage);
            vProvider.GenerateSMS(count);
        }
        public override void StartSendMessages()
        {
            vProvider.SMSReceived += new SMSReceivedDelegate(Messages.AddMessage);
            vProvider.GenerateSMS(-1);
        }
        private readonly OLEDScreen vOLEDScreen;
        private readonly PhoneBattery vBatterySimple;
        private readonly PhoneSpeaker vPhoneSpeaker;
        private readonly KeyboardWithLetters vKeyboardWithLetters;
        private readonly MicrophoneSimple vMicrophoneSimple;
        private readonly SimCardSimple vSimcardSimple;
        private readonly SMSProvider vProvider;
        private readonly MessageStorage vMessages;

        public override void Call()
        {
            throw new NotImplementedException();
        }
    }

    }

   
