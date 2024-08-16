using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESkryptering
{
    public class SqliteDataAccess
    {
        public static List<MessageModel> LoadMessages()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<MessageModel>("select * from Message", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveMessages(MessageModel message)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //cnn.Execute("insert into Message (Password, Message) values (@Password, @Message)", message);
                var query = "insert into Message (Password, Message) values (@Password, @Message)";
                //Console.WriteLine(query);
                //Console.WriteLine($"Password: {message.Password}, Message: {message.Message}");
                MessageBox.Show(query + message.Message+message.Password);
                cnn.Execute(query,message);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
