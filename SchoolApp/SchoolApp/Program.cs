using System;

namespace SchoolApp
{
    class Program
    {
        static void Main()
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Sasha" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
                Console.WriteLine("Student {0} was added", stud.StudentName);
                Console.ReadLine();
            }
        }
    }
}
