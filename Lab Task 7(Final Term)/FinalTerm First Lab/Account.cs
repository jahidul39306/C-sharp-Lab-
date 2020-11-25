using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_First_Lab
{
    abstract class Account
    {
        public string AccountHolderName { get; set; }
        public string AccId { get; set; }
        public double Balance { get; set; }
        public Account()
        {
            Console.WriteLine("Empty Account Constructor.\n");
        }
        public Account(string accName, string acId, double balance)
        {
            AccountHolderName = accName;
            AccId= acId;
            Balance = balance;
        }
        public void Deposit(int amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Successfully " + amount + " Deposited " + "in " + AccId);
            }
        }
        abstract public bool Withdraw(int amount);
        
        public void Transfer(int amount, Account receiver)
        {
            if (Withdraw(amount))
            {
                receiver.Deposit(amount);
                Console.WriteLine(amount + " Transaction succed " + "from " + AccId + " to " + receiver.AccId);
                Console.WriteLine("**************************************************************************");
            }
            else
            {
                Console.WriteLine(amount + " Transaction failed " + "from " + AccId + " to " + receiver.AccId);
                Console.WriteLine("**************************************************************************");
            }
                

        }
        public void ShowInfo()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Account Holder Name : " + AccountHolderName);
            Console.WriteLine("Account ID : " + AccId);
            Console.WriteLine("Balance : " + Balance);
            Console.WriteLine("------------------------------------------");

        }

    }
}
