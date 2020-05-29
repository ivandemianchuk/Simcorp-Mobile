using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibraryPhone.Messages.SMSProvider;

namespace ClassLibraryPhone.Messages
{
        public class MessageStorage : IEnumerable
        {
            public event SMSReceivedDelegate SMSAdded;
            public event SMSReceivedDelegate SMSRemoved;

            public void AddMessage(Message message)
            {
                Messages.Add(message);

                if (!BoolOperator(true, false))
                {

                }
                if (Filter(message))
                {
                    SMSAdded?.Invoke(message);
                }
            }

            public void RemoveMessage(Message message)
            {
                Messages.Remove(message);
                SMSRemoved?.Invoke(message);
            }

            public List<Message> SearchByUser()
            {
                return Messages.Where(m => FilterByUser(m)).ToList();
            }

            public List<Message> SearchByText()
            {
                return Messages.Where(m => FilterByText(m)).ToList();
            }

            public List<Message> SearchByDate()
            {
                return Messages.Where(m => FilterByDate(m)).ToList();
            }

            public IEnumerable<Message> GetFilteredMessages()
            {
                return Messages.Where(m => Filter(m));
            }

            public bool Filter(Message m)
            {
                var b = BoolOperator(FilterByUser(m), FilterByText(m));
                b = BoolOperator(b, FilterByDate(m));
                return b;
            }

            public bool FilterByUser(Message m)
            {
                return (UserFilter == "All users") || (m.User == UserFilter);
            }

            public bool FilterByText(Message m)
            {
                return m.Text.Contains(TextFilter);
            }

            public bool FilterByDate(Message m)
            {
                return (DateTime.Compare(FromDate, m.ReceivingTime) <= 0) &&
                       (DateTime.Compare(m.ReceivingTime, ToDate) <= 0);
            }

            public IEnumerator GetEnumerator()
            {
                return Messages.GetEnumerator();
            }

            public void SetFilter(string user, string text, DateTime from, DateTime to, Func<bool, bool, bool> boolOperator)
            {
                UserFilter = user;
                TextFilter = text;
                FromDate = from;
                ToDate = to;
                BoolOperator = boolOperator;
            }


            private List<Message> Messages = new List<Message>();

            private string UserFilter = "All users";
            private string TextFilter = "";
            private DateTime FromDate = DateTime.MinValue;
            private DateTime ToDate = DateTime.MaxValue;
            private Func<bool, bool, bool> BoolOperator = (x, y) => x || y;

        public int Count()
        {
            return Messages.Count;
        }
    }
    }
