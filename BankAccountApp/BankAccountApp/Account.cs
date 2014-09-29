using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class Account
    {
        public string accountNo;
        public string customerName;
        public double balance=0;

        public void GetDeposite(double amount)
        {
           balance += amount;
          
        }

        public void GetWithdraw(double amount)
        {
            balance -= amount;
        }
    }
}
