using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.Canonical;
using State.Live;

namespace State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // canonical
            var context = new Context(new ConcreteStateA());

            context.Request();
            context.Request();
            context.Request();

            Console.WriteLine();

            // live
            var account = new Account("Abuse");

            account.Deposit(500);
            Console.WriteLine(account.State.GetType() + " : " + account.State.Balance);

            account.Withdraw(1000);
            Console.WriteLine(account.State.GetType() + " : " + account.State.Balance);

            account.Deposit(400);
            Console.WriteLine(account.State.GetType() + " : " + account.State.Balance);

            account.Deposit(400);
            Console.WriteLine(account.State.GetType() + " : " + account.State.Balance);

            account.Deposit(4000);
            Console.WriteLine(account.State.GetType() + " : " + account.State.Balance);
        }
    }
}