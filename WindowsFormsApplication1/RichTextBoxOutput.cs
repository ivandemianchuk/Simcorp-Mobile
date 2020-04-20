using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Output
{
    public class RichTextBoxOutput : IOutput
    {
        private RichTextBox TextBox;

        public RichTextBoxOutput(RichTextBox textBox)
        {
            TextBox = textBox;
        }
        public void Write(string text)
        {
            TextBox.AppendText(text);
        }

        public void WriteLine(string text)
        {
            TextBox.AppendText(text);
            TextBox.AppendText(Environment.NewLine);
        }

    }
}
