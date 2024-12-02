using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAForms
{
    public partial class Form2 : Form
    {
        public KeyStruct publicKey;
        public KeyStruct privateKey;
        public Form1 Alice;
        public BigInteger EncryptedMessage { get; set; }
        public RSA rsa;
        public Form2(RSA rsa, Form1 Alice)
        {
            this.rsa = rsa;
            this.publicKey = rsa.publicKey;
            this.privateKey = rsa.privateKey;
            this.Alice = Alice;
            this.Alice.publicKey = this.publicKey;
            Console.WriteLine(publicKey);
            Console.WriteLine(privateKey);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = this.rsa.DecryptedMsg(this.EncryptedMessage, this.privateKey).ToString();
        }
        public void showEncrypedMessage()
        {
            BobEncryptedMessage.Text = this.EncryptedMessage.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
