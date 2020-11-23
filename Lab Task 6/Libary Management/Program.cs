using System;

namespace Libary_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student s1 = new Student("jahid", "19", "CSE", 3.54f);
            s1.ShowInfo();
            Account a1 = new Account("Jahid", "52", 1000);
            Account a2 = new Account("hid", "42", 1000);
            a1.Transfer(500, a2);
            Console.WriteLine(a1.Balance);
            Console.WriteLine(a2.Balance);
        }
    }
}
