using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProcess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account=new Account(1000.0 ,"savings");

            Subscriber subscriber = new Subscriber();

            account.ProcessingTransaction += subscriber.OnProcessingTransaction;
            account.TransactionComplete += subscriber.OnTransactionComplete;

            account.ProcessTransaction(200.0);
            account.ProcessTransaction(-50.0);
        }
    }
}
