using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsProcess
{
    internal class Account
    {
        public double balance { get; private set; }
        public string accounttype { get; private set; }

        //define delegates for the events 
        public delegate void AccountEventHandler(object sender,EventArgs e);

        //Define events
        public event AccountEventHandler ProcessingTransaction;
        public event AccountEventHandler TransactionComplete;
        
        //constructor
        //public Account() { }
        public Account(double initialbalance, string accounttype)
        {
            this.balance = initialbalance;
            this.accounttype = accounttype;
        }

        //method to process a transaction
        public void ProcessTransaction(double amount)
        {
            OnProcessingTransaction(EventArgs.Empty);
            balance += amount;
            OnTransactionComplete(EventArgs.Empty);

        }
        protected virtual void OnProcessingTransaction(EventArgs e)
        {
            ProcessingTransaction?.Invoke(this, e);
        }

        protected virtual void OnTransactionComplete(EventArgs e)
        {
           TransactionComplete?.Invoke(this, e);
        }

    }
}
