using Labb_LINQ.Data;
using Labb_LINQ.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_LINQ
{
    internal class Studentteacher
    {
        public static void TeachStudent()
        {
            Console.Clear();
            using (SchoolDbContext db = new SchoolDbContext())
            {

                var joinStuTeach = (from stu in db.Students
                                    join teach in db.Teachers
                                    on stu.TeacherID equals teach.TeacherID
                                    select new
                                    {
                                        stuName = stu.StudentName,
                                        TName = teach.TeacherName
                                    });

                foreach(var item in joinStuTeach)
                {
                    Console.WriteLine("Student Name : {0}, Teach Name : {1}", item.stuName,item.TName);
                }

                Console.WriteLine("Press Enter to go back!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
