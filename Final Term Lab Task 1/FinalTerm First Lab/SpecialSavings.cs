using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    class SpecialSavings:Savings
    {
        private double openingBalance;

        public double OpeningBalance
        {
            get { return openingBalance; }
            set { openingBalance = value; }
        }

        public SpecialSavings(String accName, string accId, double balance, int limitOfMonthlyTransaction) : base(accName, accId, balance, limitOfMonthlyTransaction)
        {
            OpeningBalance = balance;
        }

        public override bool Withdraw(int amount)
        {
            if (amount <= (Balance - OpeningBalance * 0.2))
            {
                // to take limited number of transation in a month
                if ((DateTime.Now.Day - firstTransactionDate.Day) > 30) { monthlyTransactionCount = 0; }
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
