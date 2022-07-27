using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg2._1
{
    class Account
    {
        int acc,amount;
        string name;

        public Account(int acc, string name, int amount)
        {
            this.acc = acc;
            this.name = name;
            this.amount = amount;
        }

        public void deposit(int dep)
        {
            amount += dep;

            Console.WriteLine("\nAccount balance after deposite is:" + amount);
        }

        public void withdraw(int wid)
        {
            if (amount < wid)
            {
                Console.WriteLine("\nBalance not sufficient", amount);
            }
            else
            {
                amount -= wid;
                Console.WriteLine("\nAccount balance after withdrawal is:" + amount);
            }
        }

        public void show()
        {
            Console.WriteLine("Account No:" + acc);
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Account balance:" + amount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 digit account number");
            int acc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            string name = Convert.ToString(Console.ReadLine());
            int amount = 30000;

            Console.WriteLine("\nCurrent account balance is:" + amount);
            Account a1 = new Account(acc, name, amount);


            int sel = 0;

            do
            {
                Console.WriteLine("\nSelect one option\n1 Deposit\n2 Withdraw\n3 Account details\n4 Exit");
                sel = Convert.ToInt32(Console.ReadLine());

                switch (sel)
                {
                    case 1:
                        Console.WriteLine("\nEnter the amount to deposit:");
                        int dep = Convert.ToInt32(Console.ReadLine());
                        a1.deposit(dep);                        
                        break;

                    case 2:
                        Console.WriteLine("\nEnter amount to withdraw:");
                        int wit = Convert.ToInt32(Console.ReadLine());
                        a1.withdraw(wit);
                        break;

                    case 3:
                        Console.WriteLine("\nAccount details:");
                        a1.show();
                        break;

                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
            } while (sel != 4);
        }
    }
}
