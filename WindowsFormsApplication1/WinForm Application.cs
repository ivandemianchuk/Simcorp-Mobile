using Lab2;
using Lab2.Output;
using Lab2.Speakers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private IOutput Output;
        private readonly Mobile MobilePhone = new SimcorpMobile();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Output = new RichTextBoxOutput(this.richTextBoxOutput);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MobilePhone.PlaybackComponent = new iPhoneHeadset(Output);
            }
            else if (this.radioButton2.Checked)
            {
                MobilePhone.PlaybackComponent = new SamsungHeadset(Output);
            }
            else if (this.radioButton3.Checked)
            {
                MobilePhone.PlaybackComponent = new UnknownHeadset(Output);
            }
            else if (this.radioButton4.Checked)
            {
                MobilePhone.PlaybackComponent = new PhoneSpeaker(Output);
            }

            Output.WriteLine("Playback component selected");
            Output.WriteLine("Set playback to mobile...");
            Output.WriteLine("Play sound in mobile:");
            MobilePhone.Play(new Object());
            Output.WriteLine("");
        }
    }
}
