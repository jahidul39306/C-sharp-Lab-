using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Task_3
{
    class Account
    {
        String accName;
        String acid;
        int balance;
        public String AccName
        {
            set { accName = value; }
            get { return accName; }
        }
        public String Acid
        {
            set { acid = value; }
            get { return acid; }
        }
        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public void Deposit(int amount)
        {
            Console.WriteLine("Name: {0}", accName);
            Console.WriteLine("Name: {0}", accName);
            Console.WriteLine("Name: {0}", accName);

            Console.WriteLine("Balance + {0}", amount);
        }
        public void Withdraw(int amount)
        {
            Console.WriteLine("Balance - {0}", amount);
        }
    }
}
