using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESkryptering
{
    public class MyDBContext : DbContext
    {
        public DbSet<EncryptedMessage> EncryptedMessages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-ONS01784;Initial Catalog=AESkryptering;Trust Server Certificate=True;Integrated Security = True");
        }

        //"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AESkryptering"
    }
}
