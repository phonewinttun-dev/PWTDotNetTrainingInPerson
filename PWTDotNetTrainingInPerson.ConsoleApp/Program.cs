// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using PWTDotNetTrainingInPerson.ConsoleApp;
using PWTDotNetTrainingInPersonBatch1_1.ConsoleApp;
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

//SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
//{
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

//AdoDotNetService adoDotNetService = new AdoDotNetService();

//adoDotNetService.Read();
//adoDotNetService.Create();
//adoDotNetService.Update();
//adoDotNetService.Delete();



//SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
//{
//    DataSource = ".",
//    InitialCatalog = "PWTDotNetTrainingInPerson",
//    UserID = "sa",
//    Password = "sasa@123",
//    TrustServerCertificate = true,
//};

//old flow
//using (IDbConnection db = new SqlConnection(sb.ConnectionString))
//{
//    db.Open();
//    //db work
//} //db.Dispose() will be called automatically

//using dapper
//IDbConnection is interface, not class
//using IDbConnection db = new SqlConnection(sb.ConnectionString);
//db.Open();

//DapperService dapperService = new DapperService();
//dapperService.Read();
//dapperService.Create();
//dapperService.Update();
//dapperService.Delete();

//AppDbContext db = new AppDbContext();
//List<StudentDTO> lst = db.Students.ToList();
//foreach (var item in lst)
//{
//    //string a = $"dsnfasid{item.StudentNo}fnsaidfasfnsanf";
//    Console.WriteLine($"{item.StudentID} - {item.StudentName}");
//}

//StudentDTO student = new StudentDTO()
//{
//    StudentID = 10,
//    Address = "Taunggyi",
//    DateOfBirth = new DateTime(2000, 1, 1), // 1900-01-01 12:00:00 AM
//    //DeleteFlag = false,
//    FatherName = "Father",
//    MobileNumber = "0912345678",
//    StudentName = "Tun"
//};

//db.Students.Add(student);
//int result = db.SaveChanges();

//StudentDTO? editStudent = db.Students.Where(x => x.StudentID == 6).FirstOrDefault();
//if (editStudent is not null)
//{
//    editStudent.FatherName = "New Father Name";
//    db.SaveChanges();
//}

//StudentDTO? removeStudent = db.Students.Where(x => x.StudentID == 5).FirstOrDefault();
//if (removeStudent is not null)
//{
//    db.Students.Remove(removeStudent);
//    db.SaveChanges();
//}

EFcoreService ef = new EFcoreService();
ef.Read();
//ef.Create();
//ef.Update();
//ef.Delete();


//Console.ReadLine();