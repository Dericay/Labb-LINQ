using Labb_LINQ.Data;
using Labb_LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_LINQ
{
    internal class TeacherMath
    {
        public static void TeachMath()
        {
            Console.Clear();
            using (SchoolDbContext db = new SchoolDbContext())
            {

                var Qsyntax = from t in db.Teachers
                              from m in db.Subjects
                              where t.TeacherID == m.SubjectID && m.SubjectName == "Math"
                              select new
                              {
                                  TeachName = t.TeacherName,
                                  SubName = m.SubjectName
                              };

                foreach(var item in Qsyntax)
                {
                    Console.WriteLine(item.TeachName + " " + item.SubName);
                }

                Console.WriteLine("Press Enter to go back!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
