using Labb_LINQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_LINQ
{
    internal class EditSubject
    {
        public static void Editmethod()
        {
            Console.Clear();
            using (SchoolDbContext db = new SchoolDbContext())
            {
                var editSub = from e in db.Subjects
                              where e.SubjectName == "Programing 2"
                              select e;

                foreach (var item in  editSub)
                {
                    item.SubjectName = "OOP";
                }

                try
                {
                    db.SaveChanges();
                    Console.WriteLine("Updated succesfully from Programing 2 to OOP.");
                }
                catch
                {
                    Console.WriteLine("Error updating object");
                }
                var ShowS = from s in db.Subjects
                            select new
                            {
                                SName = s.SubjectName
                            };

                foreach (var item in ShowS)
                {
                    Console.WriteLine("Subject : {0}",item.SName);
                }
                Console.WriteLine("Press Enter to go back!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
