using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AESkryptering
{
    public class UserDBContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-ONS01784;Initial Catalog=AESkryptering");
        }

        //"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AESkryptering"
    }
}
