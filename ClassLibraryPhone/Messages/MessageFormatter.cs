using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ClassLibraryPhone.Messages
{
    public class MessageFormatter
    {
        public delegate string FormatDelegate(string text);

        public MessageFormatter()
        {
            FormatMethod = NoFormat;
        }

        public string NoFormat(string message)
        {
            return message + Environment.NewLine; 
        }

        public FormatDelegate FormatMethod { get; set; }

        public string StartWithDateTimeFormat(string message)
        {
            return $"{TimeNow()} {message}" + Environment.NewLine;
        }

        public string EndWithDateTimeFormat(string message)
        {
            return $"{message} {TimeNow()}" + Environment.NewLine;
        }

        public string UpperCaseFormat(string message)
        {
            return message.ToUpper() + Environment.NewLine;
        }

        public string LowerCaseFormat(string message)
        {
            return message.ToLower() + Environment.NewLine;
        }
        public static string TimeNow()
        {
            return $"[{DateTime.Now}]";
        }

    }
}
