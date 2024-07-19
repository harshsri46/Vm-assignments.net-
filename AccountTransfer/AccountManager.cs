using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTransfer
{
    internal class AccountManager
    {

      
        public Account FromAccount {  get; set; }
        public Account ToAccount { get; set; }

        public double Amounttotransfer {  get; set; }

        public AccountManager(Account fromaccount,Account toaccount, double amounttotransfer    )
        {
            this.FromAccount = fromaccount;
            this.ToAccount = toaccount;
            this.Amounttotransfer = amounttotransfer;
        }
        public void Transfer()
        {
            lock(FromAccount)
            {
                lock (ToAccount)
                {

                    if (FromAccount.AccountBalance >= Amounttotransfer)
                    {
                        FromAccount.AccountBalance -= Amounttotransfer;
                        ToAccount.AccountBalance += Amounttotransfer;
                        Console.WriteLine($"Amount {Amounttotransfer} transferred from {FromAccount.AccountId} to {ToAccount.AccountId}");


                    }
                    else
                    {
                        Console.WriteLine($"Insufficient balance in account {FromAccount.AccountId} to transfer amount {Amounttotransfer}");
                    }

                }
            }
        }

        public void CheckBalance()
        {
            lock (FromAccount)
            {
                Console.WriteLine($"Checking the balance of {FromAccount.AccountId} :{FromAccount.AccountBalance}");
            }
            lock (ToAccount)
            {
                Console.WriteLine($"checking the balance of {ToAccount.AccountId} :{ToAccount.AccountBalance}");

            }
        }
               
    }
}
