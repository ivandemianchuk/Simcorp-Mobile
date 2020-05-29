using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPhone.Messages
{
    public class Message
    {
        public Message(string user, string text, DateTime receivingTime)
        {
            User = user;
            Text = text;
            ReceivingTime = receivingTime;
        }

        public Message(string user, string text)
        {
            User = user;
            Text = text;
            ReceivingTime = DateTime.Now;
        }
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime ReceivingTime { get; set; }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Message m = (Message)obj;
            return (User == m.User)  && (Text == m.Text) && (ReceivingTime.Equals(m.ReceivingTime));
        }
    }
}
