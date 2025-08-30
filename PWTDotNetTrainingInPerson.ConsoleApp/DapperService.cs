using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWTDotNetTrainingInPerson.ConsoleApp
{
    public class DapperService
    {
        private readonly SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder()
        {
            DataSource = ".",
            InitialCatalog = "PWTDotNetTrainingInPerson",
            UserID = "sa",
            Password = "sasa@123",
            TrustServerCertificate = true,
        };

        public void Read() 
        { 
            using IDbConnection db = new SqlConnection(sb.ConnectionString);
            
            db.Open();

            List<Students> students = db.Query<Students>("SELECT * FROM [dbo].[tbl_students]").ToList();

            db.Close();

            for (int i = 0; i < students.Count; i++)
            {
                Students item = students[i];
                Console.WriteLine($"{i + 1} {item.StudentID} {item.StudentName}");
            }

            /*
            foreach (var student in students)
            {
                Console.WriteLine($"{student.StudentID} {student.StudentName} {student.MobileNumber}");
            }
            */
        }

        public void Create() 
        { 
            using IDbConnection db = new SqlConnection(sb.ConnectionString);

            db.Open(); 

            int result = db.Execute(@"INSERT INTO [dbo].[tbl_students]
                                               ([StudentName]
                                               ,[FatherName]
                                               ,[DateOfBirth]
                                               ,[Address]
                                               ,[MobileNumber]
                                               ,[DeleteFlag])
                                         VALUES
                                               ('Myint'
                                               ,'U Tun'
                                               ,2005-12-12
                                               ,'Yangon'
                                               ,'09515151510'
                                               ,0)");

            db.Close();

            string message = result > 0 ? "Insert successful!" : "Insert failed!";
            Console.WriteLine(message);


        }

        public void Update() 
        { 
            using IDbConnection db = new SqlConnection(sb.ConnectionString);
            
            db.Open();

            int result = db.Execute(@"UPDATE [dbo].[tbl_students]
                                       SET [StudentName] = 'Zaw'
                                          ,[FatherName] = 'U Kyaw'
                                          ,[DateOfBirth] = '2000-01-01'
                                          ,[Address] = 'Myitkyina'
                                          ,[MobileNumber] = '09999999999'
                                          ,[DeleteFlag] = 0
                                     WHERE StudentID = 1");
            db.Close();

            string message = result > 0 ? "Update successful!" : "Update failed!";

            Console.WriteLine(message);
        }

        public void Delete() 
        { 
           using IDbConnection db = new SqlConnection(sb.ConnectionString);

            db.Open();

            int result = db.Execute(@"UPDATE [dbo].[tbl_students]
                             SET [DeleteFlag] = 1
                             WHERE [StudentID] = 2");

            db.Close();

            string message = result > 0 ? "Delete successful!" : "Delete failed!";

            Console.WriteLine(message);
        }
    }
}

