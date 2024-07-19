using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AccountTransfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Account accountA = new Account(101, 5000.0);
            Account accountB = new Account(102, 3000.0);

                // amounttotransfer = 400.0;

            AccountManager accountmanager = new AccountManager(accountA,accountB,1000);

            /*Thread threadt1 = new Thread(accountmanager.Transfer);
            ThreadStart threadstart=new ThreadStart(accountmanager.Transfer);
            threadt1.Start();
            */

           Thread transferThread = new Thread(new ThreadStart(accountmanager.Transfer));
            Thread checkBalanceThread=new Thread(new ThreadStart(accountmanager.CheckBalance));


            transferThread.Start();
            checkBalanceThread.Start();

           // Wait for both the transfer thread to complete before exiting the main thread
            transferThread.Join();
            checkBalanceThread.Join();

            // Print final balances
            Console.WriteLine($"Final balance of Account {accountA.AccountId}: {accountA.AccountBalance}");
            Console.WriteLine($"Final balance of Account {accountB.AccountId}: {accountB.AccountBalance}");

        }
    }
}
