using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPhone.Messages
{
    public class SMSProvider
    {
        public delegate void SMSReceivedDelegate(string message);

        public event SMSReceivedDelegate SMSReceived;

        private void RaiseSMSReceivedEvent(string message)
        {
            SMSReceived?.Invoke(message);
        }

        public void GenerateSMS()
        {
            if (SMSReceived != null)
            {
                while (true)
                    {
                    RaiseSMSReceivedEvent($"This is very informative message");
                    System.Threading.Thread.Sleep(1500);
                }
            }
        }
    }
}
