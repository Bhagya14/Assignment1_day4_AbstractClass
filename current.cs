using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task1_day4
{
    class current:account
    {
        public current(string customername, int accountbalance) : base(customername, accountbalance)
        {
            Console.WriteLine(" current object constructor");
        }
        public override void deposit(int amount)
        {
            this.accountbalance = this.accountbalance + amount;
        }

        public override void withdraw(int amount)
        {
            this.accountbalance = accountbalance - amount;
        }
    }
}
