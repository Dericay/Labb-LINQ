using Labb_LINQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_LINQ
{
    internal class UpdateTeacher
    {
        public static void ChangeTeacher()
        {
            Console.Clear();
            using (SchoolDbContext db = new SchoolDbContext())
            {
                var changeT = from c in db.Students
                              where c.TeacherID == 1
                              select c;

                foreach(var item in changeT)
                {
                    item.TeacherID = 3;
                }
                try
                {
                    db.SaveChanges();
                    Console.WriteLine("Updated succesfully from Anas to Reidar.");
                }
                catch
                {
                    Console.WriteLine("Error updating object");
                }

                var ShowT = from s in db.Students
                            join t in db.Teachers
                            on s.TeacherID equals t.TeacherID
                            select new
                            {
                                sName = s.StudentName,
                                tName = t.TeacherName
                            };
                foreach(var item in ShowT)
                {
                    Console.WriteLine("Studnet : {0}, Teacher : {1}",item.sName,item.tName);
                }
                Console.WriteLine("Press Enter to go back!");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
