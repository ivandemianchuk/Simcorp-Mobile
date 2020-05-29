using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPhone.Messages
{
    public class SMSProvider
    {
        public delegate void SMSReceivedDelegate(Message message);

        public event SMSReceivedDelegate SMSReceived;

        private void RaiseSMSReceivedEvent(Message message)
        {
            SMSReceived?.Invoke(message);
        }

        public void GenerateSMS(int count)
        {
            if (SMSReceived != null)
            {
                while (count!=0)
                    {
                    count -= 1;
                    string[] names = new string[6] { "Ivan", "Mykola", "Andrii","Oksana","Mariana","Dariia" };
                    Random rnd = new Random();
                    int i= rnd.Next(6);
                    Message message = new Message(names[i], $"This is message from {names[i]}", DateTime.Now);
                    RaiseSMSReceivedEvent(message);
                    System.Threading.Thread.Sleep(1500);
                }
            }
        }
    }
}
