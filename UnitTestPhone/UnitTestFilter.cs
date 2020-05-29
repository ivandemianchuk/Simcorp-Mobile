using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ClassLibraryPhone.Messages;
using Lab;

namespace UnitTestPhone
{
    [TestClass]
    public class UnitTestFilter
    {
        private MessageStorage Storage;

        [TestMethod]
        public void SearchByUser()
        {
            Storage = new MessageStorage();
            Storage.AddMessage(new Message("User 1", "Message 1", new DateTime(2021, 01, 01)));
            Storage.AddMessage(new Message("User 1", "Message 2", new DateTime(2020, 02, 02)));
            Storage.AddMessage(new Message("user 2", "Message 3", new DateTime(2022, 01, 01)));
            Storage.AddMessage(new Message("user 2", "Message 4", new DateTime(2022, 03, 01)));

            var expectedMessages = new List<Message>();
            expectedMessages.Add(new Message("User 1", "Message 1", new DateTime(2021, 01, 01)));
            expectedMessages.Add(new Message("User 1", "Message 2", new DateTime(2020, 02, 02)));

            Storage.SetFilter("User 1", "Meassage 2", new DateTime(), new DateTime(), (x, y) => x || y);
            var actualMesseges = Storage.SearchByUser();

  
            Assert.AreEqual(expectedMessages.Count, actualMesseges.Count);
            var actual = actualMesseges.GetEnumerator();
            var expected = expectedMessages.GetEnumerator();
            while (actual.MoveNext() && expected.MoveNext())
            {
                Assert.AreEqual(actual.Current, expected.Current);

            }
        }

        [TestMethod]
        public void SearchByText()
        {
            Storage = new MessageStorage();
            Storage.AddMessage(new Message("User 1", "Message 1", new DateTime(2021, 01, 01)));
            Storage.AddMessage(new Message("User 1", "Message 2", new DateTime(2020, 02, 02)));
            Storage.AddMessage(new Message("User 2", "Message 3", new DateTime(2022, 01, 01)));
            Storage.AddMessage(new Message("User 2", "Message 4", new DateTime(2022, 03, 01)));
            Storage.AddMessage(new Message("User 3", "Message 15", new DateTime(2022, 01, 01)));
            Storage.AddMessage(new Message("User 3", "Message 4", new DateTime(2022, 03, 01)));



            var expectedMessages = new List<Message>();
            expectedMessages.Add(new Message("User 1",  "Message 1", new DateTime(2021, 01, 01)));
            expectedMessages.Add(new Message("User 3",  "Message 15", new DateTime(2022, 01, 01)));

            Storage.SetFilter("User 1", "1", new DateTime(), new DateTime(), (a, b) => a || b);
            var actualMesseges = Storage.SearchByText();

            Assert.AreEqual(expectedMessages.Count, actualMesseges.Count);
            var actual = actualMesseges.GetEnumerator();
            var expected = expectedMessages.GetEnumerator();
            while (actual.MoveNext() && expected.MoveNext())
            {
                Assert.AreEqual(actual.Current, expected.Current);
            }
        }

        [TestMethod]
        public void SearchByDate()
        {
            Storage = new MessageStorage();
            Storage.AddMessage(new Message("User 1", "Message 1", new DateTime(2020, 01, 01)));
            Storage.AddMessage(new Message("User 1", "Message 2", new DateTime(2021, 02, 02)));
            Storage.AddMessage(new Message("User 2", "Message 3", new DateTime(2022, 01, 01)));
            Storage.AddMessage(new Message("User 2", "Message 4", new DateTime(2022, 03, 02)));
            Storage.AddMessage(new Message("User 3", "Message 15", new DateTime(2023, 01, 01)));
            Storage.AddMessage(new Message("User 3", "Message 4", new DateTime(2022, 03, 01)));

            var expectedMessages = new List<Message>();
            expectedMessages.Add(new Message("User 1",  "Message 2", new DateTime(2021, 02, 02)));
            expectedMessages.Add(new Message("User 2",  "Message 3", new DateTime(2022, 01, 01)));
            expectedMessages.Add(new Message("User 3",  "Message 4", new DateTime(2022, 03, 01)));

            Storage.SetFilter("User", "any text", new DateTime(2021, 02, 02), new DateTime(2022, 03, 01), (a, b) => a || b);
            var actualMesseges = Storage.SearchByDate();


            Assert.AreEqual(expectedMessages.Count, actualMesseges.Count);
            var actual = actualMesseges.GetEnumerator();
            var expected = expectedMessages.GetEnumerator();
            while (actual.MoveNext() && expected.MoveNext())
            {
                Assert.AreEqual(actual.Current, expected.Current);
            }
        }

        [TestMethod]
        public void AddMessage()
        {
            var Phone = new SimcorpMobile();
            var expectedMessages = new List<Message>()
                {
                    new Message("User 1","This is message from User 1",new DateTime()),
                    new Message("User 2","This is message from User 2",new DateTime()),
                    new Message("User 3","This is message from User 3",new DateTime())
                };
            Phone.Messages.SetFilter("All", "", DateTime.MinValue, DateTime.MaxValue, (a, b) => a || b);
                   
            Phone.StartSendMessages(3);
            System.Threading.Thread.Sleep(4500);

            Assert.AreEqual(expectedMessages.Count, Phone.Messages.Count());
        }
    }
}
