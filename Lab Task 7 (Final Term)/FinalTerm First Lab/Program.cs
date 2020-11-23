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
            Account a1 = new Savings("Jahid", "XY101", 7000);
            a1.ShowInfo();
            a1.Deposit(5000);
            a1.Withdraw(9700);
            a1.ShowInfo();
            Console.WriteLine();
            Account a2 = new Fixed("Robin", "TY01", 5000,5,2015);
            a2.ShowInfo();
            a2.Deposit(5000);
            a2.Withdraw(9500);
            a2.ShowInfo();
            
        }
    }
}
