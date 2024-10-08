﻿namespace AESkryptering
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Text = new TextBox();
            button1 = new Button();
            colorDialog1 = new ColorDialog();
            Decrypt = new Button();
            textBox2 = new TextBox();
            Password = new TextBox();
            label1 = new Label();
            passwordCheck = new TextBox();
            enterPasswordLable = new Label();
            getMessagesButton = new Button();
            messageListBox = new ListBox();
            SuspendLayout();
            // 
            // Text
            // 
            Text.Location = new Point(24, 69);
            Text.Margin = new Padding(3, 2, 3, 2);
            Text.Multiline = true;
            Text.Name = "Text";
            Text.PlaceholderText = "Text";
            Text.Size = new Size(291, 57);
            Text.TabIndex = 0;
            Text.TextChanged += Text_TextChanged;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(321, 125);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(87, 28);
            button1.TabIndex = 2;
            button1.Text = "Encrypt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Decrypt
            // 
            Decrypt.Location = new Point(332, 261);
            Decrypt.Margin = new Padding(3, 2, 3, 2);
            Decrypt.Name = "Decrypt";
            Decrypt.Size = new Size(84, 28);
            Decrypt.TabIndex = 3;
            Decrypt.Text = "Decrypt";
            Decrypt.UseVisualStyleBackColor = true;
            Decrypt.Click += Decrypt_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(24, 294);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Paste message to encrypt";
            textBox2.Size = new Size(392, 111);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += Text_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(24, 130);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Name = "Password";
            Password.PlaceholderText = "Select password";
            Password.Size = new Size(291, 23);
            Password.TabIndex = 1;
            Password.TextChanged += Password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(228, 23);
            label1.TabIndex = 5;
            label1.Text = "EncryptionMaster 3000";
            // 
            // passwordCheck
            // 
            passwordCheck.Location = new Point(136, 266);
            passwordCheck.Name = "passwordCheck";
            passwordCheck.Size = new Size(113, 23);
            passwordCheck.TabIndex = 6;
            // 
            // enterPasswordLable
            // 
            enterPasswordLable.AutoSize = true;
            enterPasswordLable.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterPasswordLable.Location = new Point(24, 269);
            enterPasswordLable.Name = "enterPasswordLable";
            enterPasswordLable.Size = new Size(106, 17);
            enterPasswordLable.TabIndex = 7;
            enterPasswordLable.Text = "Enter Password:";
            // 
            // getMessagesButton
            // 
            getMessagesButton.Location = new Point(445, 353);
            getMessagesButton.Name = "getMessagesButton";
            getMessagesButton.Size = new Size(103, 23);
            getMessagesButton.TabIndex = 9;
            getMessagesButton.Text = "Get Messages";
            getMessagesButton.UseVisualStyleBackColor = true;
            getMessagesButton.Click += getMessagesButton_Click;
            // 
            // messageListBox
            // 
            messageListBox.FormattingEnabled = true;
            messageListBox.ItemHeight = 15;
            messageListBox.Location = new Point(445, 142);
            messageListBox.Name = "messageListBox";
            messageListBox.Size = new Size(161, 184);
            messageListBox.TabIndex = 10;
            messageListBox.SelectedIndexChanged += messageListBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 436);
            Controls.Add(messageListBox);
            Controls.Add(getMessagesButton);
            Controls.Add(enterPasswordLable);
            Controls.Add(passwordCheck);
            Controls.Add(label1);
            Controls.Add(Password);
            Controls.Add(textBox2);
            Controls.Add(Decrypt);
            Controls.Add(button1);
            Controls.Add(Text);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Text;
        private Button button1;
        private ColorDialog colorDialog1;
        private Button Decrypt;
        private TextBox textBox2;
        private TextBox Password;
        private Label label1;
        private TextBox passwordCheck;
        private Label enterPasswordLable;
        private Button getMessagesButton;
        private ListBox messageListBox;
    }
}
