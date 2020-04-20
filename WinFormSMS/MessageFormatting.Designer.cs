using System;

namespace WinFormSMS
{
    partial class MessageFormatting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxMessages = new System.Windows.Forms.RichTextBox();
            this.formattingComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBoxMessages
            // 
            this.richTextBoxMessages.Location = new System.Drawing.Point(12, 55);
            this.richTextBoxMessages.Name = "richTextBoxMessages";
            this.richTextBoxMessages.Size = new System.Drawing.Size(353, 266);
            this.richTextBoxMessages.TabIndex = 0;
            this.richTextBoxMessages.Text = "";
            this.richTextBoxMessages.TextChanged += new System.EventHandler(this.richTextBoxMessages_TextChanged);
            // 
            // formattingComboBox
            // 
            this.formattingComboBox.AllowDrop = true;
            this.formattingComboBox.DisplayMember = "No Format";
            this.formattingComboBox.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formattingComboBox.FormattingEnabled = true;
            this.formattingComboBox.Items.AddRange(new object[] {
            "No Format",
            "Start with date time",
            "End with date time",
            "Uppercase",
            "Lowercase"});
            this.formattingComboBox.Location = new System.Drawing.Point(12, 12);
            this.formattingComboBox.Name = "formattingComboBox";
            this.formattingComboBox.Size = new System.Drawing.Size(132, 27);
            this.formattingComboBox.TabIndex = 1;
            this.formattingComboBox.Text = "Select formatting";
            this.formattingComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MessageFormatting
            // 
            this.ClientSize = new System.Drawing.Size(377, 333);
            this.Controls.Add(this.formattingComboBox);
            this.Controls.Add(this.richTextBoxMessages);
            this.Name = "MessageFormatting";
            this.Text = "Message Formatting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageFormatting_FormClosing);
            this.Load += new System.EventHandler(this.MessageFormatting_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxMessages;
        private System.Windows.Forms.ComboBox formattingComboBox;
    }
}

