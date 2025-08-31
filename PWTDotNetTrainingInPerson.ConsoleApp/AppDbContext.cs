using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PWTDotNetTrainingInPerson.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWTDotNetTrainingInPersonBatch1_1.ConsoleApp
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "PWTDotNetTrainingInPerson",
                UserID = "sa",
                Password = "sasa@123",
                TrustServerCertificate = true
            };
            optionsBuilder.UseSqlServer(sb.ConnectionString);
        }

        public DbSet<StudentDTO> Students { get; set; }
    }
}
