using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task1_day4
{
    abstract class account
    {
        private int accountid;
        private string customername;
        protected int accountbalance;
        private static int count = 1000;
        public account(string customername, int accountbalance)
        {
            this.accountid = account.count;
            this.customername = customername;
            this.accountbalance = accountbalance;
            Console.WriteLine("account abstract class constructor");
        }
        public int getbalance()
        {
            return this.accountbalance;
        }
        public void Stoppayment()
        {
            Console.WriteLine("stop payment logic");
        }
        public abstract void deposit(int amount);
        public abstract void withdraw(int amount);
        public int paccountid
        {
            get
            {
                return this.accountid;
            }
        }
        public string pcustomername
        {
            get
            {
                return this.customername;
            }
        }

    }
}
