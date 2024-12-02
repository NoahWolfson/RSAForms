namespace RSAForms
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EncryptedMessage = new Label();
            Send = new Button();
            EncryptMessage = new Button();
            Message = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 292);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "EncryptedMessage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 178);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(352, 45);
            label3.Name = "label3";
            label3.Size = new Size(74, 37);
            label3.TabIndex = 2;
            label3.Text = "Alice";
            // 
            // EncryptedMessage
            // 
            EncryptedMessage.AutoSize = true;
            EncryptedMessage.Location = new Point(357, 333);
            EncryptedMessage.Name = "EncryptedMessage";
            EncryptedMessage.Size = new Size(53, 15);
            EncryptedMessage.TabIndex = 3;
            EncryptedMessage.Text = "Message";
            // 
            // Send
            // 
            Send.Location = new Point(315, 389);
            Send.Name = "Send";
            Send.Size = new Size(144, 23);
            Send.TabIndex = 4;
            Send.Text = "Send Message";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // EncryptMessage
            // 
            EncryptMessage.Location = new Point(351, 249);
            EncryptMessage.Name = "EncryptMessage";
            EncryptMessage.Size = new Size(75, 23);
            EncryptMessage.TabIndex = 5;
            EncryptMessage.Text = "Encrypt Message";
            EncryptMessage.UseVisualStyleBackColor = true;
            EncryptMessage.Click += EncryptMessage_Click;
            // 
            // Message
            // 
            Message.Location = new Point(336, 196);
            Message.Name = "Message";
            Message.Size = new Size(100, 23);
            Message.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Message);
            Controls.Add(EncryptMessage);
            Controls.Add(Send);
            Controls.Add(EncryptedMessage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label EncryptedMessage;
        private Button Send;
        private Button EncryptMessage;
        private TextBox Message;
    }
}
