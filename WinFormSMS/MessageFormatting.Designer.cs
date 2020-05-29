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
            this.formattingComboBox = new System.Windows.Forms.ComboBox();
            this.MessageListView = new System.Windows.Forms.ListView();
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Messages = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilterUser = new System.Windows.Forms.ComboBox();
            this.FilterMessage = new System.Windows.Forms.TextBox();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxFiltersOr = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
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
            this.formattingComboBox.Size = new System.Drawing.Size(175, 27);
            this.formattingComboBox.TabIndex = 1;
            this.formattingComboBox.Text = "Select formatting";
            this.formattingComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MessageListView
            // 
            this.MessageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.Messages});
            this.MessageListView.FullRowSelect = true;
            this.MessageListView.GridLines = true;
            this.MessageListView.Location = new System.Drawing.Point(12, 141);
            this.MessageListView.Name = "MessageListView";
            this.MessageListView.Size = new System.Drawing.Size(351, 220);
            this.MessageListView.TabIndex = 2;
            this.MessageListView.TileSize = new System.Drawing.Size(250, 30);
            this.MessageListView.UseCompatibleStateImageBehavior = false;
            this.MessageListView.View = System.Windows.Forms.View.Tile;
            this.MessageListView.SelectedIndexChanged += new System.EventHandler(this.MessagesListView_SelectedIndexChanged);
            // 
            // Messages
            // 
            this.Messages.Text = "Message";
            // 
            // FilterUser
            // 
            this.FilterUser.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.FilterUser.FormattingEnabled = true;
            this.FilterUser.Items.AddRange(new object[] {
            "All users",
            "Ivan",
            "Mykola",
            "Andrii",
            "Mariana",
            "Oksana",
            "Dariia"});
            this.FilterUser.Location = new System.Drawing.Point(193, 12);
            this.FilterUser.Name = "FilterUser";
            this.FilterUser.Size = new System.Drawing.Size(170, 27);
            this.FilterUser.TabIndex = 3;
            this.FilterUser.Text = "User";
            this.FilterUser.SelectedIndexChanged += new System.EventHandler(this.filterUser_SelectedIndexChanged_1);
            // 
            // FilterMessage
            // 
            this.FilterMessage.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.FilterMessage.Location = new System.Drawing.Point(193, 45);
            this.FilterMessage.Name = "FilterMessage";
            this.FilterMessage.Size = new System.Drawing.Size(170, 27);
            this.FilterMessage.TabIndex = 4;
            this.FilterMessage.TextChanged += new System.EventHandler(this.FilterMessage_TextChanged);
            // 
            // FromDate
            // 
            this.FromDate.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FromDate.Location = new System.Drawing.Point(12, 78);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(175, 27);
            this.FromDate.TabIndex = 5;
            this.FromDate.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // ToDate
            // 
            this.ToDate.CalendarFont = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.ToDate.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ToDate.Location = new System.Drawing.Point(193, 78);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(170, 27);
            this.ToDate.TabIndex = 6;
            this.ToDate.UseWaitCursor = true;
            this.ToDate.ValueChanged += new System.EventHandler(this.ToDate_ValueChanged);
            // 
            // checkBoxFiltersOr
            // 
            this.checkBoxFiltersOr.AutoSize = true;
            this.checkBoxFiltersOr.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.checkBoxFiltersOr.Location = new System.Drawing.Point(193, 112);
            this.checkBoxFiltersOr.Name = "checkBoxFiltersOr";
            this.checkBoxFiltersOr.Size = new System.Drawing.Size(85, 23);
            this.checkBoxFiltersOr.TabIndex = 7;
            this.checkBoxFiltersOr.Text = "Filters: Or";
            this.checkBoxFiltersOr.UseVisualStyleBackColor = true;
            this.checkBoxFiltersOr.CheckedChanged += new System.EventHandler(this.checkBoxFiltersOr_CheckedChanged);
            // 
            // MessageFormatting
            // 
            this.ClientSize = new System.Drawing.Size(375, 373);
            this.Controls.Add(this.checkBoxFiltersOr);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.FilterMessage);
            this.Controls.Add(this.FilterUser);
            this.Controls.Add(this.MessageListView);
            this.Controls.Add(this.formattingComboBox);
            this.Name = "MessageFormatting";
            this.Text = "Message Formatting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageFormatting_FormClosing);
            this.Load += new System.EventHandler(this.MessageFormatting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.ComboBox formattingComboBox;
        private System.Windows.Forms.ListView MessageListView;
        private System.Windows.Forms.ColumnHeader Messages;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ComboBox FilterUser;
        private System.Windows.Forms.TextBox FilterMessage;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.CheckBox checkBoxFiltersOr;
    }
}

