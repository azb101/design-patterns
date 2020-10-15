using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.Live
{
    internal class Account
    {
        private string owner;
        public State State { get; internal set; }

        public Account(string owner)
        {
            this.owner = owner;
            this.State = new SilverState(this, 0.0);
        }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
        }

        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
        }

        public void PayInterest()
        {
            State.PayInterest();
        }
    }
}