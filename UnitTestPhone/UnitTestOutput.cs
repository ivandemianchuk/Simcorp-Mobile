using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2.Output;

namespace UnitTestPhone
{
    [TestClass]
    public class UnitTestOutput
    {
        [TestMethod]
        public void TestOutput()
        {
            FakeOutput Output = new FakeOutput();
            string testString = "Hello World";
            Output.WriteLine(testString);
            Assert.AreEqual(Output.OutputString, testString);
        }
    }
}
