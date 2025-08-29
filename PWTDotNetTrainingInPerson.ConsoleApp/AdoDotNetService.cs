using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWTDotNetTrainingInPerson.ConsoleApp
{
    internal class AdoDotNetService
    {
        SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "PWTDotNetTrainingInPerson",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true,
        };

        public void Read()
        {

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open();
            //connection အဖွင့်အပိတ်ကြားမှာ query တွေအလုပ်လုပ်မယ်

            string query = @"SELECT [StudentID]
      ,[StudentName]
      ,[FatherName]
      ,[DateOfBirth]
      ,[Address]
      ,[MobileNumber]
      ,[DeleteFlag]
  FROM [dbo].[tbl_students]";

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dataRow = dt.Rows[i];
                Console.WriteLine($"{dataRow["StudentId"]} {dataRow["StudentName"]} {dataRow["MobileNumber"]}");
            }

            connection.Close(); 

        }

        public void Create() {
            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open();
            //connection အဖွင့်အပိတ်ကြားမှာ query တွေအလုပ်လုပ်မယ်

            string query = @"INSERT INTO [dbo].[tbl_students]
           ([StudentName]
           ,[FatherName]
           ,[DateOfBirth]
           ,[Address]
           ,[MobileNumber]
           ,[DeleteFlag])
     VALUES
           ('Lin'
           ,'U Zaw'
           ,2005-11-11
           ,'Yangon'
           ,'09698765431'
           ,0)";

            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();

            connection.Close();
            string message = result > 0 ? "Insert successful" : "Insert failed";
            Console.WriteLine(message);
        }

        public void Update() {
            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open();
            //connection အဖွင့်အပိတ်ကြားမှာ query တွေအလုပ်လုပ်မယ်

            string query = @"UPDATE [dbo].[tbl_students]
                             SET [DeleteFlag] = 0
                             WHERE [StudentID] = 1";

            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();

            connection.Close();
            string message = result > 0 ? "Update successful" : "Update failed";
            Console.WriteLine(message);
        }
 
        public void Delete() {
            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            connection.Open();
            //connection အဖွင့်အပိတ်ကြားမှာ query တွေအလုပ်လုပ်မယ်

            string query = @"UPDATE [dbo].[tbl_students]
                             SET [DeleteFlag] = 1
                             WHERE [StudentID] = 3";

            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();

            connection.Close();
            string message = result > 0 ? "Delete successful" : "Delete failed";
            Console.WriteLine(message);
        }
    }
}
