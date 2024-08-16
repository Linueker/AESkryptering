using Microsoft.EntityFrameworkCore;

namespace AESkryptering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<EncryptedMessage> messages = new List<EncryptedMessage>();
        string encrypted = "";
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
        private void Decrypt_Click(object sender, EventArgs e)
        {
            textBox2.Text = Encrypt.DecryptString(textBox2.Text, passwordCheck.Text);
            passwordCheck.Clear();
        }

        private void dataBaseData_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hämta det valda objektet från ListBox och typomvandla till EncryptedMessage
            var selectedMessage = (EncryptedMessage?)dataBaseData.SelectedItem;

            // Visa 'message' i textBox2
            if (selectedMessage != null)
            {
                textBox2.Text = selectedMessage.Message;
            }
        }

        private void ListMessagesButton_Click(object sender, EventArgs e)
        {
            dataBaseData.Items.Clear();
            // Öppnar upp koppling till databasen
            using (MyDBContext dbContext = new MyDBContext())
            {
                messages = dbContext.EncryptedMessages.ToList();
            }
            foreach (var message in messages) 
            {
                dataBaseData.Items.Add(message);
            }
            dataBaseData.DisplayMember = "ID";
        }
    }
}
