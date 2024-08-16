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
            MessageModel m = new MessageModel();

            encrypted = Encrypt.EncryptString(Text.Text.ToString(), Password.Text.ToString());

            m.Message = encrypted;
            m.Password = Password.Text;

            SqliteDataAccess.SaveMessages(m);

            Text.Text = encrypted;
            Password.Text = "";

            List<MessageModel> messageModels = SqliteDataAccess.LoadMessages();
            messageListBox.Items.Clear();

            foreach (var message in messageModels)
            {
                messageListBox.Items.Add(message.Message);
            }
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

        private void getMessagesButton_Click(object sender, EventArgs e)
        {
            List<MessageModel> messageModels = SqliteDataAccess.LoadMessages();
            messageListBox.Items.Clear();

            foreach (var message in messageModels)
            {
                messageListBox.Items.Add(message.Message);
            }
        }

        private void messageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var message = messageListBox.SelectedItem;

            if (message != null)
            {
                textBox2.Text = message.ToString();
            }
        }
    }
}
