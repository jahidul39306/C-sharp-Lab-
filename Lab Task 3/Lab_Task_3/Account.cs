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
            Console.WriteLine();
            Console.WriteLine("Name: {0}", AccName);
            Console.WriteLine("Acc ID: {0}", Acid);
            Console.WriteLine("Balance: {0}", Balance);
            balance = balance + amount;
            Console.WriteLine("Deposit: {0}", amount);
            Console.WriteLine("Current Balance: {0}", Balance);
        }
        public void Withdraw(int amount)
        {
            Console.WriteLine();
            Console.WriteLine("Name: {0}", AccName);
            Console.WriteLine("Acc ID: {0}", Acid);
            Console.WriteLine("Balance: {0}", Balance);
            balance = balance - amount;
            if (balance < 0) Console.WriteLine("Balance is low for transaction");
            else
            {
                Console.WriteLine("Withdraw: {0}", amount);
                Console.WriteLine("Current Balance: {0}", Balance);
            }
        }
    }
}
