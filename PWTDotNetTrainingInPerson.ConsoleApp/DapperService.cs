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

            string message = result > 0 ? "Insert successful" : "Insert failed";
            Console.WriteLine(message);


        }

        public void Update() { }

        public void Delete() { }
    }
}

