using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_LINQ.Models
{
    internal class Student
    {
        [Key]
        public int StudentID { get; set; }
        
        public string StudentName { get; set; }

        public int TeacherID { get; set; }
    }
}
