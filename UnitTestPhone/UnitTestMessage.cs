using ClassLibraryPhone.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestPhone
{
    [TestClass]
    public class UnitTestMessage
    {
        [TestMethod]
        public void NoFormat()
        {
            MessageFormatter messageFormatter = new MessageFormatter();
            Message message = new Message("Ivan","This is test",DateTime.Now);

            Message result = messageFormatter.FormatMethod(message);

            Assert.AreEqual(new Message("Ivan","This is test\r\n",message.ReceivingTime ), result);
        }


        [TestMethod]
        public void UpperCaseFormat()
        {
            var messageFormatter = new MessageFormatter();
            messageFormatter.FormatMethod = messageFormatter.UpperCaseFormat;
            Message message = new Message("Ivan", "This is test", DateTime.Now);

            var result = messageFormatter.FormatMethod(message);

            Assert.AreEqual(new Message("Ivan","THIS IS TEST" + Environment.NewLine,message.ReceivingTime), result);
        }

        [TestMethod]
        public void LowerCaseFormat()
        {
            var messageFormatter = new MessageFormatter();
            messageFormatter.FormatMethod = messageFormatter.LowerCaseFormat;
            Message message = new Message("Ivan", "This is test", DateTime.Now);

            var result = messageFormatter.FormatMethod(message);

            Assert.AreEqual(new Message("Ivan","this is test" + Environment.NewLine,message.ReceivingTime), result);
        }
    }
}
