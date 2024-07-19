using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AccountTransfer
{
    internal class Account
    {
        private readonly object balancelock = new object();
        public int AccountId { get; set; }

        public double AccountBalance {
            get
            {
                lock (balancelock)
                {
                    return AccountBalance;
                }
            }
            set 
            {
                lock (balancelock)
                {
                    AccountBalance = value; ;
                }
            } 
        }

        public Account(int accountid,double balance) 
        { 
            this.AccountId = accountid;
            this.AccountBalance= balance;
        }
    }
}
