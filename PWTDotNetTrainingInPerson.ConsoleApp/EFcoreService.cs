using PWTDotNetTrainingInPersonBatch1_1.ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWTDotNetTrainingInPerson.ConsoleApp
{
    public class EFcoreService
    {
        AppDbContext db = new AppDbContext();

        public void Read() 
        {
            List<StudentDTO> lst = db.Students.ToList();
            foreach (var item in lst)
            {
                //string a = $"dsnfasid{item.StudentNo}fnsaidfasfnsanf";
                Console.WriteLine($"{item.StudentID} - {item.StudentName}");
            }

        }

        public void Create() 
        {

            StudentDTO newStudent = new StudentDTO()
            {
                StudentName = "Tun",
                FatherName = "Father",
                DateOfBirth = new DateTime(2005, 1, 1),
                Address = "Taunggyi",
                MobileNumber = "0912345678"
                // 1900-01-01 12:00:00 AM
                                                        //DeleteFlag = false    
            };

            db.Students.Add(newStudent);
            int result = db.SaveChanges();
            string message = result > 0 ? "Create successful!" : "Create failed!";
            Console.WriteLine(message);

        }

        public void Update() 
        {

            StudentDTO? editStudent = db.Students.Where(x => x.StudentID == 6).FirstOrDefault();
            if (editStudent is not null)
            {
                editStudent.FatherName = "New Father Name";
                int result = db.SaveChanges();
                string message = result > 0 ? "Update Successful!" : "Update Failed!";
                Console.WriteLine(message);
            }
            
        }

        public void Delete() 
        {
            StudentDTO? removeStudent = db.Students.Where(x => x.StudentID == 5).FirstOrDefault();
            if (removeStudent is not null)
            {
                db.Students.Remove(removeStudent);
                int result = db.SaveChanges();
                string message = result > 0 ? "Delete Successful!" : "Delete Failed!";
                Console.WriteLine(message);
            }
        } 
    }
}
