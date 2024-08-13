namespace AESkryptering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string text = "";
        string password = "";
        string encrypted = "";
        string decrypted = "";
        private void button1_Click(object sender, EventArgs e)
        {
            encrypted = Encrypt.EncryptString(Text.Text.ToString(), Password.Text.ToString());
            textBox2.Text = encrypted;
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            text = Text.Text;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            password = Password.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            decrypted = Encrypt.DecryptString(encrypted, password);
            textBox2.Text = decrypted;
        }
    }
}
