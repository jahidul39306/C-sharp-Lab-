using System;
using System.Collections.Generic;
using System.Text;

namespace Libary_Management
{
    class Account
    {
        private string accName;

        public string AccName
        {
            get { return accName; }
            set { accName = value; }
        }

        private string acid;

        public string AcId
        {
            get { return acid; }
            set { acid = value; }
        }

        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private Student[] students;

        public Student[] Students
        {
            get { return students; }
            set { students = value; }
        }


        public Account()
        {
            Student[] students = new Student[100];
            Console.WriteLine("Empty Constructor");
        }

        public Account(string accName, string acid, int balance)
        {
            Student[] students = new Student[100];
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(int amount)
        {
            if (balance >= amount)
            {
                balance = balance - amount;
            }
            else Console.WriteLine("Balance is low");
        }

        public void Transfer(int amount, Account receiver)
        {
            if (balance >= amount)
            {
                balance = balance - amount;
                receiver.Deposit(amount);
            }
            else Console.WriteLine("Balance is low can not transfer");
        }
    }
}
