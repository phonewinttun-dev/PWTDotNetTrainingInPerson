using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWTDotNetTrainingInPerson.ConsoleApp
{
    [Table("tbl_students")]
    public class StudentDTO
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public bool DeleteFlag { get; set; }
    }
}
