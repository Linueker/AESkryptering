using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            textBox2.Text = encrypted;

            // Spara lösenord och krypterad sträng i databasen
            SaveToDatabase(password, encrypted);
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

        private void SaveToDatabase(string password, string encryptedMessage)
        {
            string connectionString = "Data Source=TIM;Initial Catalog=PasswordDB;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Passwords (Password, Message) VALUES (@Password, @Message)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Message", encryptedMessage);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
