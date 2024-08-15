namespace AESkryptering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string password = "";
        string encrypted = "";
        string decrypted = "";
        private void button1_Click(object sender, EventArgs e)
        {
            encrypted = Encrypt.EncryptString(Text.Text.ToString(), Password.Text.ToString());
            Text.Text = encrypted;
            using (MyDBContext dbContext = new MyDBContext())
            {
                EncryptedMessage message = new EncryptedMessage();
                message.Message = encrypted;
                dbContext.EncryptedMessages.Add(message);
                dbContext.SaveChanges();
            }

            Password.Text = "";
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {

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
            decrypted = Encrypt.DecryptString(textBox2.Text, passwordCheck.Text);
            textBox2.Text = decrypted;

        }
        
    }
}
