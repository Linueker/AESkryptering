namespace AESkryptering
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
            SuspendLayout();
            // 
            // Text
            // 
            Text.Location = new Point(27, 51);
            Text.Name = "Text";
            Text.PlaceholderText = "Text";
            Text.Size = new Size(332, 27);
            Text.TabIndex = 0;
            Text.TextChanged += Text_TextChanged;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(27, 117);
            button1.Name = "button1";
            button1.Size = new Size(99, 37);
            button1.TabIndex = 1;
            button1.Text = "Encrypt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Decrypt
            // 
            Decrypt.Location = new Point(27, 227);
            Decrypt.Name = "Decrypt";
            Decrypt.Size = new Size(96, 38);
            Decrypt.TabIndex = 2;
            Decrypt.Text = "Decrypt";
            Decrypt.UseVisualStyleBackColor = true;
            Decrypt.Click += Decrypt_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 271);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(447, 147);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += Text_TextChanged;
            // 
            // Password
            // 
            Password.Location = new Point(27, 84);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(332, 27);
            Password.TabIndex = 4;
            Password.TextChanged += Password_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Password);
            Controls.Add(textBox2);
            Controls.Add(Decrypt);
            Controls.Add(button1);
            Controls.Add(Text);
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
    }
}
