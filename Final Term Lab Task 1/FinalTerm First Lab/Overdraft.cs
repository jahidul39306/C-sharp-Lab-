using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    class Overdraft:Account
    {
        DateTime firstOverLimitDate;
        TimeSpan timeDifference;
        public int OverDraftlimit { get; set; }
        public Overdraft(String accName, string accId, double balance, int overDrfatlimit) : base(accName, accId, balance)
        {
            this.OverDraftlimit = overDrfatlimit;
        }

        public override bool Withdraw(int amount)
        {
            timeDifference = DateTime.Now - firstOverLimitDate;
            //Console.WriteLine(timeDifference.Days); // to check time limit is okay or not
            if(amount <= (Balance + OverDraftlimit) && (timeDifference.Days) > 30)
            {
                firstOverLimitDate = DateTime.Now;
                Balance -= amount;
                Console.WriteLine(amount + " has been witdrawn successfully from " + AccId);
                return true;
            }

            else if(amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine(amount + " has been witdrawn successfully from " + AccId);
                return true;
            }
            else Console.WriteLine("Not Enough Balance in " + AccId + " for " + amount + " Withdraw"); return false;
        }
    }
}
