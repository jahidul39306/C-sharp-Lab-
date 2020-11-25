using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    class Savings:Account
    {
        protected DateTime firstTransactionDate;
        protected TimeSpan diffrenceTime;

        protected int limitOfMonthlyTransaction;

        public int LimitOfMonthlyTransaction
        {
            get { return limitOfMonthlyTransaction; }
            set { limitOfMonthlyTransaction = value; }
        }

        protected int monthlyTransactionCount = 0;
        public Savings()
        {
            Console.WriteLine("Empty savings Constructor.\n");
        }
        public Savings(String accName, string accId, double balance, int limitOfMonthlyTransaction) :base(accName,accId,balance)
        {
            this.limitOfMonthlyTransaction = limitOfMonthlyTransaction;
        }

        public override bool Withdraw(int amount)
        {
            if (amount <= (Balance - 500))
            {
                // to take limited number of transation in a month
                diffrenceTime = DateTime.Now - firstTransactionDate;
                //Console.WriteLine(diffrenceTime.Days); // to check time limit is okay or not
                if ((diffrenceTime.Days) > 30) { monthlyTransactionCount = 0; } 
                if (monthlyTransactionCount == 0)
                {
                    firstTransactionDate = DateTime.Now;
                    Balance -= amount;
                    monthlyTransactionCount++;
                    Console.WriteLine(amount + " has been witdrawn successfully from " + AccId);
                    return true;
                }
                else if (monthlyTransactionCount < LimitOfMonthlyTransaction)
                {
                    Balance -= amount;
                    monthlyTransactionCount++;
                    Console.WriteLine(amount + " has been witdrawn successfully from " + AccId);
                    return true;
                }
                else Console.WriteLine(amount + " Can not be withdraw because more than " + LimitOfMonthlyTransaction + " transaction"); return false;
            }
            else Console.WriteLine("Not Enough Balance in " + AccId + " for " + amount + " Withdraw"); return false;
        }
    }
}
