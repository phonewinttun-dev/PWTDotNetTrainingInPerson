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
           (<StudentName, nvarchar(100),>
           ,<FatherName, nvarchar(100),>
           ,<DateOfBirth, datetime,>
           ,<Address, nvarchar(255),>
           ,<MobileNumber, nvarchar(20),>
           ,<DeleteFlag, bit,>)";

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
   SET [StudentName] = <StudentName, nvarchar(100),>
      ,[FatherName] = <FatherName, nvarchar(100),>
      ,[DateOfBirth] = <DateOfBirth, datetime,>
      ,[Address] = <Address, nvarchar(255),>
      ,[MobileNumber] = <MobileNumber, nvarchar(20),>
      ,[DeleteFlag] = <DeleteFlag, bit,>
 WHERE <Search Conditions,,>";

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

            string query = @"UPDATE FROM [dbo].[tbl_students]
SET [DeleteFlag] = 1
      WHERE <Search Conditions,,>";

            SqlCommand cmd = new SqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery();

            connection.Close();
            string message = result > 0 ? "Delete successful" : "Delete failed";
            Console.WriteLine(message);
        }
    }
}
