// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using PWTDotNetTrainingInPerson.ConsoleApp;
using System.Data;
using System.Net.Http.Headers;

// 'Ctrl + .' on SqlConnectionStringBuilder

// comment - Ctrl + K + C
// uncomment - Ctrl + K + U

//SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
//sqlConnectionStringBuilder.DataSource = ".";
//sqlConnectionStringBuilder.InitialCatalog = "PWTDotNetTrainingInPerson";
//sqlConnectionStringBuilder.UserID = "sa";
//sqlConnectionStringBuilder.Password = "sasa@123";
//sqlConnectionStringBuilder.TrustServerCertificate = true;

//Console.WriteLine(sqlConnectionStringBuilder.ConnectionString);

//SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);

//Console.WriteLine("Opening connection...");
//connection.Open();
//Console.WriteLine("Connection opened.");

//string query = @"SELECT [StudentID]
//      ,[StudentName]
//      ,[FatherName]
//      ,[DateOfBirth]
//      ,[Address]
//      ,[MobileNumber]
//      ,[DeleteFlag]
//  FROM [dbo].[tbl_students]
//";

//SqlCommand cmd = new SqlCommand(query, connection); // to connect command with connection
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);// to fetch data from database
//DataTable dt = new DataTable(); // in-memory representation of data

//Console.WriteLine("Closing connection...");
//connection.Close();
//Console.WriteLine("Connection closed.");

//Console.ReadKey();

//SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder() {
//    DataSource = ".",
//    InitialCatalog = "PWTDotNetTrainingInPerson",
//    UserID = "sa",
//    Password = "sasa@123",
//    TrustServerCertificate = true,
//};

//SqlConnection connection = new SqlConnection(sb.ConnectionString);
//connection.Open();

////connection အဖွင့်အပိတ်ကြားမှာ query တွေအလုပ်လုပ်မယ်

//string query = @"SELECT [StudentID]
//      ,[StudentName]
//      ,[FatherName]
//      ,[DateOfBirth]
//      ,[Address]
//      ,[MobileNumber]
//      ,[DeleteFlag]
//  FROM [dbo].[tbl_students]";

//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//adapter.Fill(dt);


//connection.Close();

AdoDotNetService adoDotNetService = new AdoDotNetService();
//adoDotNetService.Create();
//adoDotNetService.Update();
adoDotNetService.Delete();
