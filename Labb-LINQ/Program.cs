namespace Labb_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome! Choose one of the options below!");
                Console.WriteLine();
                Console.WriteLine("1.Teachers in math\n2.Students with teachers\n3.Contains\n4.Edit Subject\n5.Update students teacher");

                string UserInput = Console.ReadLine();

                switch(UserInput)
                {
                    case "1":
                        TeacherMath.TeachMath();
                        break;
                        case "2":
                        Studentteacher.TeachStudent();
                        break;
                        case "3":
                        Contains.CheckContain();
                        break;
                        case "4":
                        EditSubject.Editmethod();
                        break;
                        case "5":
                        UpdateTeacher.ChangeTeacher();
                        break;
                }
            }
        }
    }
}