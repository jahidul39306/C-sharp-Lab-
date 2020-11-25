using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    class Fixed :Account
    {
        private int tenureYear;

        public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        private DateTime openingYear; 

        /*public int OpeningYear
        {
            get { return openingYear; }
            set { openingYear = value; }
        }*/

        public Fixed()
        {
            Console.WriteLine("Empty Fixed Constructor.");
        }
        public Fixed(String accName, string accId, double balance,int tenureYear) : base(accName, accId, balance)
        {
            this.tenureYear = tenureYear;
            openingYear = DateTime.Now;
        }

        public override bool Withdraw(int amount)
        {
            if ((DateTime.Now.Year - openingYear.Year) == tenureYear && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine(amount + " has been witdrawn successfully from " + AccId);
                return true;
            }
            else
                Console.WriteLine("Withdraw failed from " + AccId); return false;
        }
    }
}
