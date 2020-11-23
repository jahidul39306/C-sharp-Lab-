using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    class Savings:Account
    {
        private int limitOfMonthlyTransaction;

        public int LimitOfMonthlyTransaction
        {
            get { return limitOfMonthlyTransaction; }
            set { limitOfMonthlyTransaction = value; }
        }
        public Savings()
        {
            Console.WriteLine("Empty savings Constructor.");
        }
        public Savings(String accName,string accId,double balance):base(accName,accId,balance)
        {
            this.limitOfMonthlyTransaction = 5;
        }

        public override void Withdraw(int amount)
        {
            if (amount <= (Balance - 500))
            {
                Balance -= amount;
            }
            else
                Console.WriteLine("Withdraw failed.");
        }

       public override void ShowInfo()
        {
            Console.WriteLine("Account Holder Name : " + AccountHolderName);
            Console.WriteLine("Account ID : " + AccId);
            Console.WriteLine("Balance : " + Balance);

        }
    }
}
