using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vazquez_OOPBank
{
    internal class Bank
    {
        private int balance;
       public Bank(int amount)
        {
            balance = amount;
        }
        public int GetBalance()
        {
            return balance;
        }

        public int add(int amount)
        {
            return balance += amount;
        }
        public int subtract(int amount)
        { 
            if (amount > 500)
            {
                amount = 500;
            }
            if (balance-amount <= 0)
            {
                amount = balance;
            }
            balance -= amount;
            return balance;
        }
    }
}
