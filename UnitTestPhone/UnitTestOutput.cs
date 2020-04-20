using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab.Output;
using Lab.Speakers;

namespace UnitTestPhone
{
    [TestClass]
    public class UnitTestOutput
    {
        [TestMethod]
        public void TestOutput_Simple()
        {
            FakeOutput Output = new FakeOutput();
            string testString = "Hello World";
            Output.WriteLine(testString);
            Assert.AreEqual(Output.OutputString, testString);
        }

        [TestMethod]
        public void TestOutput_PlayiPhoneHeadset()
        {
            FakeOutput Output = new FakeOutput();
            iPhoneHeadset headset = new iPhoneHeadset(Output);
            headset.Play(null);
            Assert.AreEqual(Output.OutputString, "iPhoneHeadset sound");
        }

        [TestMethod]
        public void TestOutput_PlaySamsungHeadset()
        {
            FakeOutput Output = new FakeOutput();
            SamsungHeadset headset = new SamsungHeadset(Output);
            headset.Play(null);
            Assert.AreEqual(Output.OutputString, "SamsungHeadset sound");
        }

        [TestMethod]
        public void TestOutput_PlayUnknownHeadset()
        {
            FakeOutput Output = new FakeOutput();
            UnknownHeadset headset = new UnknownHeadset(Output);
            headset.Play(null);
            Assert.AreEqual(Output.OutputString, "UnknownHeadset sound");
        }
    }
}
