using System;

namespace Lab_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // student class
            Student s = new Student();
            s.Name = "Jahid";
            s.Id = "19-39306-1";
            s.Department = "CSE";
            s.Cgpa = 3.97f;
            s.ShowInfo();

            // triangle class
            Console.WriteLine();
            Triangle t = new Triangle();
            t.X = 8;
            t.Y = 8;
            t.Z = 7;
            t.ShowInfo();
            t.TestTriangle();

            //account class
            Account ac = new Account();
            ac.AccName = "Jahid";
            ac.Acid = "19-39306-1";
            ac.Balance = 800;
            ac.Deposit(150);
            ac.Withdraw(50);
            ac.Withdraw(950);

            //course class
            Course c = new Course();
            Console.WriteLine();
            c.CourseName = "OOB2";
            c.CourseCode = "56";
            c.CourseCredit = 3;
            c.ShowCourseInfo();
        }
    }
}
