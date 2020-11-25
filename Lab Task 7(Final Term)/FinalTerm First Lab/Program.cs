using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Savings("Jahid", "XY101", 7000, 5);
            a1.ShowInfo();
            a1.Deposit(5000);
            a1.Withdraw(70000);
            a1.Withdraw(70);
            a1.ShowInfo();
            Console.WriteLine();

            Account a4 = new SpecialSavings("Nahid", "YZ101", 1000, 3);
            a4.ShowInfo();
            a4.Deposit(5000);
            a4.Withdraw(70000);
            a4.Withdraw(70);
            a4.ShowInfo();
            Console.WriteLine();

            Account a2 = new Overdraft("Nayamut", "PP002", 3000, 1000);
            a2.Transfer(4000, a1);
            a2.Transfer(2500, a1);
            a2.ShowInfo();
            a2.Deposit(50000);
            a2.Withdraw(49000);
            a2.ShowInfo();
            a2.Transfer(50, a1);
            Console.WriteLine();

            Account a3 = new Fixed("Robin", "TY01", 5000, 5);
            a3.ShowInfo();
            a3.Deposit(5000);
            a3.Withdraw(9500);
            a3.ShowInfo();
            a4.Transfer(5850, a3);
            a4.ShowInfo();
            a3.ShowInfo();
            Console.WriteLine();

        }
    }
}
