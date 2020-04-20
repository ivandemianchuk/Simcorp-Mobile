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
            string message = "This is test";

            string result = messageFormatter.FormatMethod(message);

            Assert.AreEqual(message + Environment.NewLine, result);
        }


        [TestMethod]
        public void UpperCaseFormat()
        {
            var messageFormatter = new MessageFormatter();
            messageFormatter.FormatMethod = messageFormatter.UpperCaseFormat;

            var result = messageFormatter.FormatMethod("This is test");

            Assert.AreEqual(("THIS IS TEST" + Environment.NewLine), result);
        }

        [TestMethod]
        public void LowerCaseFormat()
        {
            var messageFormatter = new MessageFormatter();
            messageFormatter.FormatMethod = messageFormatter.LowerCaseFormat;

            var result = messageFormatter.FormatMethod("This is test");

            Assert.AreEqual(("this is test" + Environment.NewLine), result);
        }
    }
}
