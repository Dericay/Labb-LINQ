using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_LINQ.Models
{
    internal class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        public string TeacherName { get; set; }
        public int SubjectID { get; set; }
    }
}
