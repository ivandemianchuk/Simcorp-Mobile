using ClassLibraryPhone.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClassLibraryPhone.Messages.MessageFormatter;
using static ClassLibraryPhone.Messages.SMSProvider;

namespace WinFormSMS
{
    public partial class MessageFormatting : Form
    {

        private readonly MessageFormatter Formatter = new MessageFormatter();

        private Thread phoneThread;
        public MessageFormatting()
        {
            InitializeComponent();
            SMSProvider provider = new SMSProvider();
            provider.SMSReceived += new SMSReceivedDelegate(OnSMSReceived);
            phoneThread = new Thread(provider.GenerateSMS);
            phoneThread.Start();
            
        }
        private void MessageFormatting_Load(object sender, EventArgs e)
        {

        }

        private void OnSMSReceived(string message)
        {
            if (richTextBoxMessages.InvokeRequired)
            {
                richTextBoxMessages.Invoke(new SMSReceivedDelegate(OnSMSReceived), message);
                return;
            }
            richTextBoxMessages.AppendText(Formatter.FormatMethod(message));
        }

        private void richTextBoxMessages_TextChanged(object sender, EventArgs e)
        {
            
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
    }
 }
