using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProcess
{
    internal class Subscriber
    {
        public void OnProcessingTransaction(object sender, EventArgs e)
        {
            Console.WriteLine("Processing Transaction...");
        }

        public void OnTransactionComplete(object sender, EventArgs e)
        {
            if(sender is Account account)
            {
                Console.WriteLine($"Transaction Complete.New balance:{account.balance}, Account Type:{account.accounttype}");
            }
        }
    }
}
