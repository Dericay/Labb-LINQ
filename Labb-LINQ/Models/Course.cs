﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_LINQ.Models
{
    internal class Course
    {
        [Key]
        public int CourseID { get; set; }

        public string CourseName { get; set; }


    }
}
