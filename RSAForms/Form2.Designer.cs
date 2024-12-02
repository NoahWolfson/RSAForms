namespace RSAForms
{
    /**
     * this form represents Bob
     * */
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            PublicKey = new Label();
            PrivateKey = new Label();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            BobEncryptedMessage = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(637, 106);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Private Key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 106);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Public Key";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(360, 56);
            label3.Name = "label3";
            label3.Size = new Size(64, 37);
            label3.TabIndex = 2;
            label3.Text = "Bob";
            // 
            // PublicKey
            // 
            PublicKey.AutoSize = true;
            PublicKey.Location = new Point(62, 145);
            PublicKey.Name = "PublicKey";
            PublicKey.Size = new Size(62, 15);
            PublicKey.TabIndex = 3;
            PublicKey.Text = "Public Key";
            // 
            // PrivateKey
            // 
            PrivateKey.AutoSize = true;
            PrivateKey.Location = new Point(640, 145);
            PrivateKey.Name = "PrivateKey";
            PrivateKey.Size = new Size(62, 15);
            PrivateKey.TabIndex = 4;
            PrivateKey.Text = "Public Key";
            // 
            // button2
            // 
            button2.Location = new Point(296, 198);
            button2.Name = "button2";
            button2.Size = new Size(158, 23);
            button2.TabIndex = 6;
            button2.Text = "DecryptMessage";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 236);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 7;
            label4.Text = "Message";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(349, 273);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 8;
            // 
            // BobEncryptedMessage
            // 
            BobEncryptedMessage.AutoSize = true;
            BobEncryptedMessage.Location = new Point(349, 180);
            BobEncryptedMessage.Name = "BobEncryptedMessage";
            BobEncryptedMessage.Size = new Size(53, 15);
            BobEncryptedMessage.TabIndex = 9;
            BobEncryptedMessage.Text = "Message";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BobEncryptedMessage);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(PrivateKey);
            Controls.Add(PublicKey);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label PublicKey;
        private Label PrivateKey;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label BobEncryptedMessage;
    }
}