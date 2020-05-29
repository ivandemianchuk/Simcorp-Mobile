using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ClassLibraryPhone.Messages
{
    public class MessageFormatter
    {
        public delegate Message FormatDelegate(Message text);

        public MessageFormatter()
        {
            FormatMethod = NoFormat;
        }

        public Message NoFormat(Message message)
        {
            string text = message.Text + Environment.NewLine;
            return new Message(message.User, text, message.ReceivingTime);
        }

        public FormatDelegate FormatMethod { get; set; }

        public Message StartWithDateTimeFormat(Message message)
        {
            string text = $"[{message.ReceivingTime}] {message.Text}" + Environment.NewLine;
            return new Message(message.User, text, message.ReceivingTime);

        }

        public Message EndWithDateTimeFormat(Message message)
        {
            string text = $"{message.Text} [{message.ReceivingTime}]" + Environment.NewLine;
            return new Message(message.User, text, message.ReceivingTime);
        }

        public Message UpperCaseFormat(Message message)
        {
            string text = message.Text.ToUpper() + Environment.NewLine;
            return new Message(message.User, text, message.ReceivingTime);
        }

        public Message LowerCaseFormat(Message message)
        {
            string text = message.Text.ToLower() + Environment.NewLine;
            return new Message(message.User, text, message.ReceivingTime);
        }
        public static string TimeNow()
        {
            return $"[{DateTime.Now}]";
        }

    }
}
