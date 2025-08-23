// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");

// 'Ctrl + .' on SqlConnectionStringBuilder

// comment - Ctrl + K + C
// uncomment - Ctrl + K + U

SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
sqlConnectionStringBuilder.DataSource = ".";
sqlConnectionStringBuilder.InitialCatalog = "PWTDotNetTrainingInPerson";
sqlConnectionStringBuilder.UserID = "sa";
sqlConnectionStringBuilder.Password = "sasa@123";
sqlConnectionStringBuilder.TrustServerCertificate = true;

Console.WriteLine(sqlConnectionStringBuilder.ConnectionString);

SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);

Console.WriteLine("Opening connection...");
connection.Open();
Console.WriteLine("Connection opened.");

Console.WriteLine("Closing connection...");
connection.Close();
Console.WriteLine("Connection closed.");

Console.ReadKey();
