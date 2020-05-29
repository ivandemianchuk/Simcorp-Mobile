using ClassLibraryPhone.Messages;
using Lab;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using static ClassLibraryPhone.Messages.MessageFormatter;
using static ClassLibraryPhone.Messages.SMSProvider;

namespace WinFormSMS
{
    public partial class MessageFormatting : Form
    {
        private readonly Mobile Phone;

        private readonly MessageFormatter Formatter = new MessageFormatter();
        private delegate void SafeCallDelegate(string text);
        private List<ClassLibraryPhone.Messages.Message> ListOfMessages = new List<ClassLibraryPhone.Messages.Message>();

        private Thread phoneThread;
        public MessageFormatting()
        {
            Phone = new SimcorpMobile();
            InitializeComponent();
            MaximizeBox = false;
            FilterUser.SelectedIndex = 0;
            Phone.Messages.SMSAdded += new SMSReceivedDelegate(OnSMSReceived);
            phoneThread = new Thread(Phone.StartSendMessages);
            phoneThread.Start();
        }
        private void MessageFormatting_Load(object sender, EventArgs e)
        {
        }

        private void OnSMSReceived(ClassLibraryPhone.Messages.Message message)
        {
            if (MessageListView.InvokeRequired)
            {
                MessageListView.Invoke(new SMSReceivedDelegate(OnSMSReceived), message);
            }
            else
            {
                ListOfMessages.Add(Formatter.FormatMethod(message));
                ShowMessage(ListOfMessages);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormatDelegate[] formatDelegates = new FormatDelegate[]
            {
                Formatter.NoFormat,
                Formatter.StartWithDateTimeFormat,
                Formatter.EndWithDateTimeFormat,
                Formatter.UpperCaseFormat,
                Formatter.LowerCaseFormat
            };
            Formatter.FormatMethod = formatDelegates[formattingComboBox.SelectedIndex];
        }

        private void MessageFormatting_FormClosing(object sender, FormClosingEventArgs e)
        {
            phoneThread.Abort();
        }

        private void ShowMessage(List<ClassLibraryPhone.Messages.Message> messages)
        {
            MessageListView.Items.Clear();
            foreach (ClassLibraryPhone.Messages.Message message in messages)
                MessageListView.Items.Add(new ListViewItem(new[] { message.User, message.Text }));
        }

        private void MessagesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshFilters();
        }

        private void filterUser_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RefreshFilters();
        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshFilters();
        }

        private void checkBoxFiltersOr_CheckedChanged(object sender, EventArgs e)
        {
            RefreshFilters();
        }

        private void RefreshFilters()
        {
            Func<bool, bool, bool> func = (x, y) => x && y;
            if (checkBoxFiltersOr.Checked)
            {
                func = (x, y) => x || y;
            }
            var user = FilterUser.SelectedItem.ToString();
            var text = FilterMessage.Text;
            var fromDate = FromDate.Value;
            var toDate = ToDate.Value;
            Phone.Messages.SetFilter(user, text, fromDate, toDate, func);
        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {
            RefreshFilters();
        }

        private void FilterMessage_TextChanged(object sender, EventArgs e)
        {
            RefreshFilters();
        }
    }
 }