using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_task1_day4
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("enter customer name:");
                string customername = Console.ReadLine();
                Console.WriteLine("enter account balance");
                int accountbalance = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("account type:");
                string accounttype = Console.ReadLine();
                account obj = null;
                if (accounttype == "saving")
                {
                    obj = new savings(customername, accountbalance);
                }
                else if (accounttype == "current")
                {
                    obj = new current(customername, accountbalance);
                }
                if (obj != null)
                {
                    Console.WriteLine(obj.paccountid);
                    Console.WriteLine(obj.pcustomername);
                    int balance = obj.getbalance();
                    Console.WriteLine("balance:" + balance);
                    Console.WriteLine("enter amount to deposit");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    obj.deposit(amount);
                    balance = obj.getbalance();
                    Console.WriteLine("balance:" + balance);
                    Console.WriteLine("enter amount to withdraw:");
                    amount = Convert.ToInt32(Console.ReadLine());
                    obj.withdraw(amount);
                    balance = obj.getbalance();
                    Console.WriteLine("balance:" + balance);
                    obj.Stoppayment();
                }
                Console.ReadLine();
            }
        }
    }

