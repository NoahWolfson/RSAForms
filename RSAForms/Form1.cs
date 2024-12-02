
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

/**
 * this form represents Alice
 * */
namespace RSAForms
{
    public partial class Form1 : Form
    {
        public RSA rsa;
        public Form2 Bob;
        public KeyStruct publicKey { get; set; }
        public BigInteger encryptedMessage;

        public Form1()
        {
            InitializeComponent();
            this.rsa = new RSA();
            this.Bob = new Form2(this.rsa, this);
            Bob.Show();
        }

        private void EncryptMessage_Click(object sender, EventArgs e)
        {
            Console.WriteLine(publicKey);
            this.encryptedMessage = this.rsa.EncryptMessage(BigInteger.Parse(Message.Text), publicKey);
            EncryptedMessage.Text = this.encryptedMessage.ToString();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            this.Bob.EncryptedMessage = this.encryptedMessage;
            Bob.showEncrypedMessage();

        }
    }
}
