using Labb_LINQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb_LINQ
{
    internal class Contains
    {
        public static bool CheckContain()
        {
            Console.Clear();
            using (SchoolDbContext db = new SchoolDbContext())
            {
                bool containsPrograming = db.Subjects.Any(SubName => SubName.SubjectName == "Programing 1");

                if (containsPrograming == true)
                {
                    Console.WriteLine("Subjects contains *Programing 1*");
                }
                else
                {
                    Console.WriteLine("Subjects doest NOT Contain *Programing 1*");
                }
                Console.WriteLine("Press Enter to go back!");
                Console.ReadKey();
                Console.Clear();

                return containsPrograming;

                
            }
        }
    }
}
